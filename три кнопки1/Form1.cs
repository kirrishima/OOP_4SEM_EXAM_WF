using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace три_кнопки1
{
    public partial class Form1 : Form
    {
        private string allLetters = "ЯЧСМИТЬБЮФЫВАПРОЛДЖЭЙЦУКЕНГШЩЗХЪ";
        private int current = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += allLetters[current++];
            current %= allLetters.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.Text += textBox1.Text[textBox1.TextLength - 1];
            }
        }
    }
}
