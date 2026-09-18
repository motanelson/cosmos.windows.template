using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Image i; Bitmap b; int value = 0; int value2 = 0; int xx = 0; int yy = 0; Graphics ee; int xxx = 0; int yyy = 0; int xxxx = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double[] dcos = { 1.00, 0.707, 0.00, -0.707, -1.00, -0.707, 0.00, 0.707, 1.00 };
            double[] dsin = { 0.00, 0.707, 1.00, 0.707, 0.00, -0.707, -1.00, -0.707, 0.0 };
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            xxx = pictureBox1.Width / 2;
            yyy = pictureBox1.Height / 2;
            ee = Graphics.FromImage(b);
            Pen ppp = new Pen(Color.FromArgb(0, 0, 0));
            Pen ppp2 = new Pen(Color.FromArgb(255, 255, 255));
            Brush p1 = new SolidBrush(Color.FromArgb(255, 255, 255, 255));

            Brush p2 = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
            for (int a = 0; a < 8; a++) {
                Rectangle r = new Rectangle(a*10,a*10,100,100);
                Rectangle rr = new Rectangle(a * 10, a * 10, 100, 10);
                ee.FillRectangle(p1,r);
                ee.DrawRectangle(ppp, r);
                ee.FillRectangle(p2, rr);
                ee.DrawRectangle(ppp2, rr);

            }
            
            ppp.Dispose();
            p1.Dispose();
            p2.Dispose();
            ppp2.Dispose();
            ee.Dispose();

        }
    }
}
