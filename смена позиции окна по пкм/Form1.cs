using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace экзамен_ооп
{
    public partial class Form1 : Form
    {
        private Point[] currentPosition =
        {
            new Point(0, 0),
            new Point(0, 400),
            new Point(500, 800),
            new Point(800, 0)
        };
        private int currentIndexPosition = 0;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(500, 400);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
            
                this.Location = currentPosition[currentIndexPosition];
                currentIndexPosition = (currentIndexPosition + 1) % currentPosition.Length;
            }
        }
    }
}
