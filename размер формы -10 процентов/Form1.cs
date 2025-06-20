using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace размер_формы__10_процентов
{   

    public partial class Form1 : Form
    {
        private Timer timer;
        private double originalWeigth;
        private double originalHeight;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();    
            originalHeight = this.Height;
            originalWeigth = this.Width;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Height = (int)(this.Height * 0.9);
                this.Width = (int)(this.Width * 0.9);
                timer.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Height = (int)(originalHeight);
            this.Width = (int)(originalWeigth);
            timer.Stop();
        }
    }
}
