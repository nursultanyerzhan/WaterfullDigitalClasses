using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace WaterfullDigitalClasses
{
    class SearchDeep
    {        
        public int x;
        public int y;
        public Bitmap bitmap;
        public Forcompkoord2 forck;

        public SearchDeep(int x, int y, Bitmap bitmap, Forcompkoord2 forck)
        {
            this.x = x;
            this.y = y;
            this.bitmap = bitmap;
            this.forck = forck;
        }

        public bool timer_Tick()
        {
            bool flagTruth = false;
            try
            {
                forck.minimumLevel(forck);
                bitmap = forck.img;
                flagTruth = true;
            }
            catch
            {
                forck.x = this.x;
                forck.y = this.y;
                flagTruth = false;
            }
            return flagTruth;
        }
    }
    class Forcompkoord2
    {
        public int x;
        public int y;
        public int minimum;
        public Bitmap img;
        public Color pixel;
        public int bParam;
        public int rParam;
        public int aParam;

        public Forcompkoord2()
        {
            x = new int();
            y = new int();
        }
        public Forcompkoord2(int ClonX, int ClonY, Bitmap ClonBMP, int aParam, int rParam, int bParam)
        {
            x = ClonX;
            y = ClonY;
            img = ClonBMP;
            this.bParam = bParam;
            this.rParam = rParam;
            this.aParam = aParam;
        }

        public Forcompkoord2 minimumLevel(Forcompkoord2 forcompkoord)
        {
            int i, j, min = 256, index = -1;
            i = forcompkoord.x;
            j = forcompkoord.y;
            int[] massive = new int[8];
            Color p0, p1, p2, p3, p4, p5, p6, p7;
            p0 = forcompkoord.img.GetPixel(i - 1, j - 1);
            massive[0] = p0.G;
            p1 = forcompkoord.img.GetPixel(i - 1, j);
            massive[1] = p1.G;
            p2 = forcompkoord.img.GetPixel(i - 1, j + 1);
            massive[2] = p2.G;
            p3 = forcompkoord.img.GetPixel(i, j + 1);
            massive[3] = p3.G;
            p4 = forcompkoord.img.GetPixel(i + 1, j + 1);
            massive[4] = p4.G;
            p5 = forcompkoord.img.GetPixel(i + 1, j);
            massive[5] = p5.G;
            p6 = forcompkoord.img.GetPixel(i + 1, j - 1);
            massive[6] = p6.G;
            p7 = forcompkoord.img.GetPixel(i, j - 1);
            massive[7] = p7.G;
            for (int k = 0; k < 8; k++)
            {
                if (massive[k] < min)
                {
                    min = massive[k];
                    index = k;
                    forcompkoord.minimum = min;
                }
            }
            switch (index)
            {
                case 0:
                    forcompkoord.x = i - 1;
                    forcompkoord.y = j - 1;
                    forcompkoord.pixel = p0; break;
                case 1:
                    forcompkoord.x = i - 1;
                    forcompkoord.y = j;
                    forcompkoord.pixel = p1; break;
                case 2:
                    forcompkoord.x = i - 1;
                    forcompkoord.y = j + 1;
                    forcompkoord.pixel = p2; break;
                case 3:
                    forcompkoord.x = i;
                    forcompkoord.y = j + 1;
                    forcompkoord.pixel = p3; break;
                case 4:
                    forcompkoord.x = i + 1;
                    forcompkoord.y = j + 1;
                    forcompkoord.pixel = p4; break;
                case 5:
                    forcompkoord.x = i + 1;
                    forcompkoord.y = j;
                    forcompkoord.pixel = p5; break;
                case 6:
                    forcompkoord.x = i + 1;
                    forcompkoord.y = j - 1;
                    forcompkoord.pixel = p6; break;
                case 7:
                    forcompkoord.x = i;
                    forcompkoord.y = j - 1;
                    forcompkoord.pixel = p7; break;
                default:
                    break;
            }
            forcompkoord.img.SetPixel(forcompkoord.x, forcompkoord.y, Color.FromArgb(aParam, rParam, forcompkoord.minimum + 1, bParam));
            return forcompkoord;
        }
    }
}
