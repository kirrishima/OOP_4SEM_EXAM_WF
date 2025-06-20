<#
.SYNOPSIS
    ������������� ������� � ��������� ��� ������� (.csproj) � ������� (.sln).
.PARAMETER SolutionPath
    ���� � ����� .sln. �� ��������� � ������� ����� � ������������ .sln � ���.
#>

param(
    [string]$SolutionPath = (Get-ChildItem -Path . -Filter *.sln | Select-Object -First 1).FullName
)

if (-not (Test-Path $SolutionPath)) {
    Write-Error "�� ������ .sln �� ���� '$SolutionPath'"
    exit 1
}

# �������� � ���������� �� .sln, ����� ���� � �������� ���� ��������������
Push-Location (Split-Path $SolutionPath)

# �������, ����� ������� ��� ���� � �������
$existing = dotnet sln $SolutionPath list `
    | Select-String '\.csproj' `
    | ForEach-Object { $_.Line.Trim() }

# ������ ��� .csproj � ������� ����� � ���������
$all = Get-ChildItem -Path . -Recurse -Filter *.csproj |
    ForEach-Object { $_.FullName.TrimStart((Get-Location).Path + '\') }

foreach ($proj in $all) {
    if ($existing -contains $proj) {
        Write-Host "���������� (��� ��������): $proj"
    }
    else {
        Write-Host "���������: $proj"
        dotnet sln $SolutionPath add $proj
    }
}

Pop-Location
