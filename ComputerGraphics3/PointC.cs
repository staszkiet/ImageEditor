using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ComputerGraphics3
{
    public class PointC
    {
        public static int Count = 0;
        public int X
        {
            get
            {
                return P.X;
            }
        }
        public int Y
        {
            get
            {
                return P.Y;
            }
        }

        public int ID;

        public Point P;

        public PointC(Point p)
        {
            this.P = p;
            ID = Count;
            Count++;
        }
        public PointC(int x, int y)
        {
            this.P = new Point(x, y);
            ID = Count;
            Count++;
        }
    }


}
