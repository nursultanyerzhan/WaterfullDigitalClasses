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
    public partial class ShowSlide : Form
    {
        public ShowSlide()
        {
            InitializeComponent();
        }
        public static int Interval = 3;
        public static short scale = 100;
        String[] path;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Multiselect = true;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    path = open.FileNames;
                }
                for (int i = 0; i < path.Length; i++)
                {
                    listBox1.Items.Add(path[i]);
                }
            }
            catch
            {
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            try
            {
                pictureBox1.Image = Image.FromFile(listBox1.SelectedItem.ToString());
            }
            catch
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                listBox1.SelectedIndex++;
            }
            catch
            {
                listBox1.SelectedIndex = 0; 
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                toolStripButton3.Image = WaterfullDigitalClasses.Properties.Resources.play_7272;
            }
            else
            {
                try
                {
                    listBox1.SelectedIndex = 0; 
                    timer1.Enabled = true;
                    toolStripButton3.Image = WaterfullDigitalClasses.Properties.Resources.pause_9032;
                }
                catch
                {
                    MessageBox.Show("Не выбрано папка с файлами","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);                    
                }
                
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WaterfullDigitalClasses.Properties.Resources._1;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(toolStripComboBox1.SelectedIndex)
            {
                case 0: pictureBox1.SizeMode = PictureBoxSizeMode.Normal; 
                    toolStripButton6.Enabled = false;
                    toolStripButton7.Enabled = false;
                    toolStripLabel1.Enabled = false;
                    pictureBox1.Dock = DockStyle.Fill;
                    break;
                case 1: pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; 
                    toolStripButton6.Enabled = false;
                    toolStripButton7.Enabled = false;
                    toolStripLabel1.Enabled = false;
                    pictureBox1.Dock = DockStyle.Fill;
                    break;
                case 2: pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
                    toolStripButton6.Enabled = false;
                    toolStripButton7.Enabled = false;
                    toolStripLabel1.Enabled = false;
                    pictureBox1.Dock = DockStyle.Fill;
                    break;
                case 3: pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 
                    toolStripButton6.Enabled = false;
                    toolStripButton7.Enabled = false;
                    toolStripLabel1.Enabled = false;
                    break;
                case 4: pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Dock = DockStyle.None;
                    pictureBox1.Width = splitContainer1.Panel2.Width;
                    pictureBox1.Height = splitContainer1.Panel2.Height;
                    toolStripLabel1.Text = "100%";
                    scale = 100;
                    toolStripButton6.Enabled = true;
                    toolStripButton7.Enabled = true;
                    toolStripLabel1.Enabled = true;
                    break;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ShowSettings ss = new ShowSettings();
            ss.ShowDialog();
            timer1.Interval = Interval * 100;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = (int)(pictureBox1.Width * 1.2);
            pictureBox1.Height = (int)(pictureBox1.Height * 1.2);
            scale = (short)(scale * 1.2);
            toolStripLabel1.Text = scale.ToString() + "%";
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = (int)(pictureBox1.Width / 1.2);
            pictureBox1.Height = (int)(pictureBox1.Height / 1.2);
            scale = (short)(scale / 1.2);
            toolStripLabel1.Text = scale.ToString() + "%";
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
