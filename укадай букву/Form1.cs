using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace укадай_букву
{
    public partial class Form1 : Form
    {
        private static string allLetters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧЪЫЬЭЮЯ";
        private static int lehgth = allLetters.Length;
        private static Random random = new Random();
        int rand = random.Next(0, lehgth);

        public Form1()
        {
            InitializeComponent();
            label2.Text = allLetters[rand].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToUpper() == allLetters[rand].ToString())
            {
                MessageBox.Show("угадал");
            }
            else
            {
                MessageBox.Show("не угадал");
            }
        }
    }
}
