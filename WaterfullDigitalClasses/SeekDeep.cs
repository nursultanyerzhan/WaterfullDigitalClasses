using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WaterfullDigitalClasses
{
    public partial class SeekDeep : Form
    {
        public static int aParametr = 255;
        public static int rParametr = 63;
        public static int bParametr = 255;
        public SeekDeep()
        {
            InitializeComponent();
            listBitmap = new List<Bitmap>();
        }

        Color clr = new Color();
        Bitmap bmpq;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Cross;
                bmpq = new Bitmap(pictureBox1.Image);
                clr = bmpq.GetPixel(e.X, e.Y);
                toolStripStatusLabel1.Text = "x,y = (" + e.X.ToString() + " , " + e.Y.ToString() + ")    H = " + clr.G.ToString();
            }
            catch
            {
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        SearchDeep sd;
        Forcompkoord2 forck;
        Bitmap b;
        List<Forcompkoord> lstXY;
        List<Bitmap> listBitmap;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            b = new Bitmap(pictureBox1.Image);
            forck = new Forcompkoord2(e.X, e.Y, b, aParametr, rParametr, bParametr);
            sd = new SearchDeep(e.X, e.Y, b, forck);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 150; i++)
            {
                sd.timer_Tick();
                pictureBox1.Image = sd.bitmap;                
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = op.FileName;
                    pictureBox1.Load(pictureBox1.ImageLocation);
                    int w = pictureBox1.Image.Width;
                    int h = pictureBox1.Image.Height;
                    pictureBox1.Size = new Size(w, h);
                    this.Size = new Size(w + 48, h + 100);
                    if (pictureBox1.Width < 717)
                    {
                        this.Width = 717;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверный файл для открытия", "Внимание!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                pictureBox1.Image.Save(sfd.FileName + ".png");
            }
            catch { }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                int count = -1;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                string nameOfPicture = Path.GetFileNameWithoutExtension(sfd.FileName);

                foreach (Bitmap b_object in listBitmap)
                {
                    count++;
                    b_object.Save(Path.GetDirectoryName(sfd.FileName) + "\\" + nameOfPicture + count.ToString() + ".bmp");
                }
                MessageBox.Show("Скрины успешно сохранено");
            }
            catch { }
        }
        int count = 0;
        private void SeekDeep_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            switch (symbol)
            {
                case ' ':
                    timer1.Start();
                    break;
                case 'p':
                    timer1.Stop();
                    break;
                case '+':
                    Bitmap ls = new Bitmap(pictureBox1.Image);
                    listBitmap.Add(ls);
                    count++;
                    toolStripLabel1.Text = "Количества скринов " + count.ToString();
                    break;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
