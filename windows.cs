using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 438);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public partial class Form1 : Form
    {
        private Image i; Bitmap b; int value = 0; int value2 = 0; int xx = 0; int yy = 0; Graphics ee; int xxx = 0; int yyy = 0; int xxxx = 10;

        public Form1()
        {
            InitializeComponent();
        }
        private void newWin(int x,int y) 
        {
            Pen ppp = new Pen(Color.FromArgb(0, 0, 0));
            Pen ppp2 = new Pen(Color.FromArgb(255, 255, 255));
            Brush p1 = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            Brush p2 = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
            Rectangle r = new Rectangle(x, y, 100, 100);
            Rectangle rr = new Rectangle(x, y, 100, 10);
            ee = Graphics.FromImage(b);
            ee.FillRectangle(p1, r);
            ee.DrawRectangle(ppp, r);
            ee.FillRectangle(p2, rr);
            ee.DrawRectangle(ppp2, rr);


            ppp.Dispose();
            p1.Dispose();
            p2.Dispose();
            ppp2.Dispose();
            ee.Dispose();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            double[] dcos = { 1.00, 0.707, 0.00, -0.707, -1.00, -0.707, 0.00, 0.707, 1.00 };
            double[] dsin = { 0.00, 0.707, 1.00, 0.707, 0.00, -0.707, -1.00, -0.707, 0.0 };
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            xxx = pictureBox1.Width / 2;
            yyy = pictureBox1.Height / 2;
            
            
            for (int a = 0; a < 8; a++) {
                newWin(a * 10+10, a * 10+10);
               

            }
            
           

        }
    }
}
