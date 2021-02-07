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
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent(); //MessageBox.Show(axWindowsMediaPlayer1.settings.volume.ToString());
            axWindowsMediaPlayer1.URL = Application.StartupPath + "\\Звук волнующегося моря - вода.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timer2.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.004;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 1;
        }
    }
}
