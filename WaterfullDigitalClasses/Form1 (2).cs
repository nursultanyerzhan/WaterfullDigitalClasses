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
    public partial class Form1 : Form
    {
        public static int vysota = 60;
        public static bool autoFill = false;
        public Form1()
        {
            InitializeComponent(); 
            lstXY = new List<Forcompkoord>();
            listBitmap = new List<Bitmap>();
        }
        SearchDeep sd;
        Forcompkoord2 forck;
        Bitmap b;
        List<Forcompkoord> lstXY;
        List<Bitmap> listBitmap;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            b = new Bitmap(pictureBox1.Image);
            forck = new Forcompkoord2(e.X,e.Y,b);
            sd = new SearchDeep(e.X,e.Y,b,forck);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            for (int i = 0; i < 50; i++)
            {
                sd.timer_Tick();
                pictureBox1.Image = sd.bitmap;
                Forcompkoord XY = new Forcompkoord(sd.forck.x, sd.forck.y,b);
                lstXY.Add(XY);
                /*if (!sd.timer_Tick())
                {
                    this.timer1.Enabled = false;
                }*/                
            }
        }

        void complete()
        {            
            lstXY = razmnozhenie(lstXY);
            setpiksel(lstXY);            
        }
        void setpiksel(List<Forcompkoord> L_massive)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            foreach (Forcompkoord f_object in L_massive)
            {
                bmp.SetPixel(f_object.x, f_object.y, Color.FromArgb(255, 63, vysota, 255));
            }
            pictureBox1.Image = bmp;
        }
        private List<Forcompkoord> razmnozhenie(List<Forcompkoord> masForc)
        {
            List<Forcompkoord> returner = new List<Forcompkoord>();

            foreach (Forcompkoord f_object in masForc)
            {
                f_object.minimumLevel(f_object, vysota);
                foreach (Forcompkoord f_for_add in f_object.lst)
                {
                    returner.Add(f_for_add);
                }
            }
            return returner;
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
                toolStripStatusLabel1.Text = "x,y = (" + e.X.ToString() + " , " + e.Y.ToString() + ")    H = " + clr.G.ToString();// + "R = " + clr.R.ToString() + " A = " + clr.A + " B = " + clr.B.ToString();
            }
            catch
            {
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            switch (symbol)
            {
                case ' ':
                    complete();    
                    break;
                case 'p': 
                    timer1.Stop();
                    break;
                case '+':
                    Bitmap bnmp = new Bitmap(pictureBox1.Image);
                    listBitmap.Add(bnmp);
                    break;
            }
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Default;
            }
            catch
            {
            }
        }

        private void новаяЗадачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
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
                if (this.Width < 717)
                {
                    this.Width = 717;
                }
            }            
        }

        private void слайдшоуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSlide sl = new ShowSlide();
            sl.Show();
        }

        private void панельУправлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelSettings ps = new PanelSettings();
            ps.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void перезапускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void сохранитьТекущийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                pictureBox1.Image.Save(sfd.FileName + ".png");
                MessageBox.Show("Снимок сохранено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch { }
        }

        private void сохранитьМножествоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = -1;
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                string nameOfPicture = Path.GetFileNameWithoutExtension(sfd.FileName);

                for (int i = 0; i < 10; i++)
                {
                    count++;
                    listBitmap[i].Save(Path.GetDirectoryName(sfd.FileName) + "\\" + nameOfPicture + count.ToString() + ".bmp");
                }
                /*foreach (Bitmap b_object in listBitmap)
                {                    
                }*/
            }
            catch { }  
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В процессе разработки", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Снимок сохранено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
    class Forcompkoord
    {
        public int x;
        public int y;
        public Bitmap img;
        public List<Forcompkoord> lst;
        public int level;

        public Forcompkoord()
        {
            x = new int();
            y = new int();
        }
        public Forcompkoord(int ClonX, int ClonY, Bitmap ClonBMP)
        {
            x = ClonX;
            y = ClonY;
            img = ClonBMP;
            lst = new List<Forcompkoord>();
        }

        public void minimumLevel(Forcompkoord forcompkoord, int l)
        {
            int i, j;
            i = forcompkoord.x;
            j = forcompkoord.y;
            Color p0, p1, p2, p3, p4, p5, p6, p7, p;
            if (i > 2 && j > 2 && j < img.Height - 5 && i < img.Width - 5)
            {
                p = forcompkoord.img.GetPixel(i, j);
                p0 = forcompkoord.img.GetPixel(i - 1, j - 1);
                p1 = forcompkoord.img.GetPixel(i - 1, j);
                p2 = forcompkoord.img.GetPixel(i - 1, j + 1);
                p3 = forcompkoord.img.GetPixel(i, j + 1);
                p4 = forcompkoord.img.GetPixel(i + 1, j + 1);
                p5 = forcompkoord.img.GetPixel(i + 1, j);
                p6 = forcompkoord.img.GetPixel(i + 1, j - 1);
                p7 = forcompkoord.img.GetPixel(i, j - 1);

                if (p1.G < l)
                {
                    Forcompkoord f1;
                    f1 = new Forcompkoord(i - 1, j, forcompkoord.img);
                    f1.level = l - p1.G;
                    f1.setPixel(f1, l);
                    lst.Add(f1);
                }
                if (p2.G < l)
                {
                    Forcompkoord f1;
                    f1 = new Forcompkoord(i - 1, j + 1, forcompkoord.img);
                    f1.level = l - p2.G;
                    f1.setPixel(f1, l);
                    lst.Add(f1);
                }
                if (p3.G < l)
                {
                    Forcompkoord f1;
                    f1 = new Forcompkoord(i, j + 1, forcompkoord.img);
                    f1.level = l - p3.G;
                    f1.setPixel(f1, l);
                    lst.Add(f1);
                }
                if (p4.G < l)
                {
                    Forcompkoord f1;
                    f1 = new Forcompkoord(i + 1, j + 1, forcompkoord.img);
                    f1.level = l - p4.G;
                    f1.setPixel(f1, l);
                    lst.Add(f1);
                }
                if (p5.G < l)
                {
                    Forcompkoord f1;
                    f1 = new Forcompkoord(i + 1, j, forcompkoord.img);
                    f1.level = l - p5.G;
                    f1.setPixel(f1, l);
                    lst.Add(f1);
                }
                if (p6.G < l)
                {
                    Forcompkoord f1;
                    f1 = new Forcompkoord(i + 1, j - 1, forcompkoord.img);
                    f1.level = l - p6.G;
                    f1.setPixel(f1, l);
                    lst.Add(f1);
                }
                if (p7.G < l)
                {
                    Forcompkoord f1;
                    f1 = new Forcompkoord(i, j - 1, forcompkoord.img);
                    f1.level = l - p7.G;
                    f1.setPixel(f1, l);
                    lst.Add(f1);
                }
                if (p0.G < l)
                {
                    Forcompkoord f1;
                    f1 = new Forcompkoord(i - 1, j - 1, forcompkoord.img);
                    f1.level = l - p0.G;
                    f1.setPixel(f1, l);
                    lst.Add(f1);
                }
            }
        }

        public void setPixel(Forcompkoord forcompkoord, int level)
        {
            forcompkoord.img.SetPixel(forcompkoord.x, forcompkoord.y, Color.FromArgb(255, 63, level, 255));
        }
    }
}
