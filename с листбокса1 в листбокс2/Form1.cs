using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace с_листбокса1_в_листбокс2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string selected = listBox1.SelectedItem.ToString();
            listBox2.Items.Add(selected);
            listBox1.Items.Remove(selected);
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            string selected = listBox2.SelectedItem.ToString();
            listBox1.Items.Add(selected);
            listBox2.Items.Remove(selected);
        }
    }
}
