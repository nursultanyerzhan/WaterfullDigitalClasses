using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WaterfullDigitalClasses
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Starting first = new Starting();
            first.Opacity = 0;
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(8);
            first.Show();
            while(end > DateTime.Now)
            {
                Application.DoEvents();
            }
            first.Close();
            first.Dispose();
            Application.Run(new Form1());
        }
    }
}
