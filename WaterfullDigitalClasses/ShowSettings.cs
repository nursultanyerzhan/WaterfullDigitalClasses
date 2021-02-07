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
    public partial class ShowSettings : Form
    {
        public ShowSettings()
        {
            InitializeComponent();
            trackBar1.Value = ShowSlide.Interval;
            label2.Text = ShowSlide.Interval.ToString();
        }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            ShowSlide.Interval = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();        
        }
    }
}
