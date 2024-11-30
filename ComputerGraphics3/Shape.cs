using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComputerGraphics3
{
    public class Shape
    {
        public List<PointC> tab;
        ModificationManager m;
        public Shape(List<PointC> points, ModificationManager m) 
        {
            tab = points;
            this.m = m;
        }

        public void Fill(Bitmap bm, Bitmap original, bool reverse)
        {
            List<int> idx = new List<int>();
            List<AED> ActiveEdges = new List<AED>();
            for(int j = 0; j < tab.Count; j++)
            {
                idx.Add(j);
            }
            idx.Sort((x, y) => (int)tab[x].Y - (int)tab[y].Y != 0 ? (int)tab[x].Y - (int)tab[y].Y : (int)tab[x].X - (int)tab[y].X);
            int scanline = (int)tab[idx[0]].Y;
            int end = tab[idx[tab.Count() - 1]].Y;
            int i = 0;
            List<int> IdxOnScanline = new List<int>();
            scanline++;
            while (scanline < end)
            {
                if ((int)tab[idx[i]].Y <= scanline - 1)
                {
                    do
                    {
                        IdxOnScanline.Add(idx[i]);
                        i++;
                        if (IdxOnScanline.Count != 0 && IdxOnScanline.Count % 2 == 0)
                        {
                            for (int k = (int)tab[idx[i - 2]].X; k <= (int)tab[idx[i - 1]].X; k++)
                            {
                                if (!reverse)
                                {
                                    bm.SetPixel(k, scanline - 1, m.ModifyPixel(original.GetPixel(k, scanline - 1)));
                                }
                                else
                                {
                                    bm.SetPixel(k, scanline - 1, original.GetPixel(k, scanline - 1));
                                }
                            }
                        }
                    } while (i < tab.Count() && (int)tab[idx[i]].Y == (int)tab[idx[i - 1]].Y);
                    foreach (int index in IdxOnScanline)
                    {
                        int previdx = index == 0 ? tab.Count() - 1 : index - 1;
                        int nextidx = (index + 1) % tab.Count();
                        if ((int)tab[previdx].Y >= (int)tab[index].Y)
                        {
                            if ((int)tab[previdx].Y != (int)tab[index].Y)
                            {
                                AED pom = new AED();
                                int prevX = (int)tab[previdx].X;
                                int X = (int)tab[index].X;
                                int Y = (int)tab[index].Y;
                                int prevY = (int)tab[previdx].Y;
                                pom.ymax = (int)tab[previdx].Y;
                                pom.diff = (float)(prevX - X) / (float)(prevY - Y);
                                pom.x = (int)tab[index].X + pom.diff;
                                pom.higherid = previdx;
                                pom.lowerid = index;
                                ActiveEdges.Add(pom);
                            }
                        }
                        else
                        {
                            ActiveEdges.RemoveAll((x) => x.lowerid == previdx && x.higherid == index);
                        }
                        if ((int)tab[nextidx].Y >= (int)tab[index].Y)
                        {
                            if ((int)tab[nextidx].Y != (int)tab[index].Y)
                            {
                                AED pom = new AED();
                                int nextX = (int)tab[nextidx].X;
                                int X = (int)tab[index].X;
                                int Y = (int)tab[index].Y;
                                int nextY = (int)tab[nextidx].Y;
                                pom.ymax = (int)tab[nextidx].Y;
                                pom.diff = (float)(nextX - X) / (float)(nextY - Y);
                                pom.x = (int)tab[index].X + pom.diff;
                                pom.higherid = nextidx;
                                pom.lowerid = index;
                                ActiveEdges.Add(pom);
                            }
                        }
                        else
                        {
                            ActiveEdges.RemoveAll((x) => x.lowerid == nextidx && x.higherid == index);
                        }
                    }
                    IdxOnScanline = new List<int>();

                }
                ActiveEdges.Sort((x, y) => (int)x.x - (int)y.x);
                for (int j = 1; j < ActiveEdges.Count; j = j + 2)
                {
                    for (int k = (int)ActiveEdges[j - 1].x; k <= Math.Ceiling(ActiveEdges[j].x); k++)
                    {
                        if (!reverse)
                        {
                            bm.SetPixel(k, scanline - 1, m.ModifyPixel(original.GetPixel(k, scanline - 1)));
                        }
                        else
                        {
                            bm.SetPixel(k, scanline - 1, original.GetPixel(k, scanline - 1));
                        }
                    }
                }
                foreach (AED a in ActiveEdges)
                {
                    a.x += a.diff;
                }
                scanline++;
            }

        }
    }

    public class AED
    {
        public float ymax;
        public float x;
        public float diff;
        public int higherid;
        public int lowerid;
    }
}
