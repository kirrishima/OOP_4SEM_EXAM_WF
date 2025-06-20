<#
.SYNOPSIS
    Автоматически находит и добавляет все проекты (.csproj) в решение (.sln).
.PARAMETER SolutionPath
    Путь к файлу .sln. По умолчанию – текущая папка и единственный .sln в ней.
#>

param(
    [string]$SolutionPath = (Get-ChildItem -Path . -Filter *.sln | Select-Object -First 1).FullName
)

if (-not (Test-Path $SolutionPath)) {
    Write-Error "Не найден .sln по пути '$SolutionPath'"
    exit 1
}

# Перейдем в директорию со .sln, чтобы пути к проектам были относительными
Push-Location (Split-Path $SolutionPath)

# Считаем, какие проекты уже есть в решении
$existing = dotnet sln $SolutionPath list `
    | Select-String '\.csproj' `
    | ForEach-Object { $_.Line.Trim() }

# Найдем все .csproj в текущей папке и подпапках
$all = Get-ChildItem -Path . -Recurse -Filter *.csproj |
    ForEach-Object { $_.FullName.TrimStart((Get-Location).Path + '\') }

foreach ($proj in $all) {
    if ($existing -contains $proj) {
        Write-Host "Пропускаем (уже добавлен): $proj"
    }
    else {
        Write-Host "Добавляем: $proj"
        dotnet sln $SolutionPath add $proj
    }
}

Pop-Location
