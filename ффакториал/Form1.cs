using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ффакториал
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                int SelectedNumber = int.Parse(listBox1.SelectedItem.ToString());
                long factorial = CountFactorial(SelectedNumber);
                textBox1.Text = factorial.ToString();
            }
            else
            {
                textBox1.Text = "0";
            }
        }
        private long CountFactorial(int number)
        {
            long factorial = 1;
            for(int i = 1; i <= number; i++)
            {
                factorial *= i;

            }
            return factorial;
        }


    }
}
