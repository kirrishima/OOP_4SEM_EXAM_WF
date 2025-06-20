using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace цифры_в_верх__буквы_в_низ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            this.Text = " ";
            string a = textBox1.Text;

            foreach(char c in a)
            {
                if (char.IsDigit(c))
                {
                    this.Text += c;
                }
            }

            foreach(char c in a)
            {
                if (char.IsLetter(c))
                {
                    toolStripStatusLabel1.Text += c;
                }
            }
        }
    }
}
