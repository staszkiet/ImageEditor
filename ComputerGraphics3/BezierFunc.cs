using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics3
{
    public class BezierFunc
    {
        public List<PointC> ControlPoints = new List<PointC>();
        Pen p = new Pen(new SolidBrush(Color.Black));
        public PointC Selected;
        public Dictionary<int, int> mapping = new Dictionary<int, int>();
        public BezierFunc(Point start, Point end)
        {
            ControlPoints.Add(new PointC(start));
            ControlPoints.Add(new PointC(end));
        }

        public void Draw(Graphics g)
        {
            //g.DrawLine(p, start, end);
            Brush b = new SolidBrush(Color.Black);
            foreach(PointC point in ControlPoints)
            {
                g.FillEllipse(new SolidBrush(Color.Green), point.X - 5, point.Y - 5,  10, 10);
            }
            double t = 0d;
            double interval = 1d / 1000d;
            double x;
            double y;
            int n = ControlPoints.Count;
            while (t <= 1)
            {
                x = 0;
                y = 0;
                for(int i = 0; i < n; i++)
                {
                    x += Helpers.binom(n-1, i) * Math.Pow((1 - t), n - i - 1) * Math.Pow(t, i) * ControlPoints[i].X;
                    y += Helpers.binom(n-1, i) * Math.Pow((1 - t), n - i - 1) * Math.Pow(t, i) * ControlPoints[i].Y;
                }
                mapping[(int)x] = (int)y;
                g.FillRectangle(b, (int)x, (int)y, 1, 1);
                t+= interval;
            }
            for (int i = 0; i <= 255; i++)
            {
                if (!mapping.ContainsKey(i))
                {
                    mapping[i] = mapping[i - 1];
                }
            }
        }
    }
}
