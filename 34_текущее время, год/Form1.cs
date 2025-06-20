using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34_текущее_время__год
{
    public partial class Form1 : Form
    {
        DateTime now = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = now.Year.ToString();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = now.Hour.ToString();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = now.Minute.ToString();
        }
    }
}
