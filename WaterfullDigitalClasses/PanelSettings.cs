using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaterfullDigitalClasses
{
    public partial class PanelSettings : Form
    {
        public PanelSettings()
        {
            InitializeComponent();
            trackBar1.Value = (int)Form1.vysota;
            groupBox1.Text = "Максимальная высота = " + Form1.vysota.ToString();
            trackBar2.Value = Form1.aParametr;
            trackBar3.Value = Form1.rParametr;
            trackBar4.Value = Form1.bParametr;
            SetColor();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            groupBox1.Text = "Максимальная высота = " + trackBar1.Value.ToString() + " см";
            Form1.vysota = trackBar1.Value;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбран режим - 'ручной'", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Form1.autoFill = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбран режим - 'автономный'", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Form1.autoFill = true;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        void SetColor()
        {
            Bitmap bmp = new Bitmap(pictureBox8.Image);
            for (int i = 0; i < pictureBox8.Width; i++)
            {
                for (int j = 0; j < pictureBox8.Height; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(trackBar2.Value, trackBar3.Value, trackBar1.Value, trackBar4.Value));
                }
            }
            pictureBox8.Image = bmp;
        }

        void SetColor(int a,int r,int b)
        {
            Bitmap bmp = new Bitmap(pictureBox8.Image);
            for (int i = 0; i < pictureBox8.Width; i++)
            {
                for (int j = 0; j < pictureBox8.Height; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(a, r, b));
                }
            }/*
            trackBar2.Value = a;
            trackBar3.Value = r;
            trackBar4.Value = b;*/
            Form1.aParametr = a;
            Form1.rParametr = r;
            Form1.bParametr = b;
            //pictureBox8.Image = bmp;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Form1.aParametr = trackBar2.Value;
            SetColor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Form1.rParametr = trackBar3.Value;
            SetColor();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            Form1.bParametr = trackBar4.Value;
            SetColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SetColor(255, 0, 232); 
            MessageBox.Show("Цвет выбран","Информация",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SetColor(255, 237, 36);
            MessageBox.Show("Цвет выбран", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
 
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SetColor(255, 195,244);
            MessageBox.Show("Цвет выбран", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
