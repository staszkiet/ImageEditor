using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics3
{
    public static class Helpers
    {
        public static int distance(int x, int y, int x1, int y1)
        {
            return (int)Math.Sqrt((x - x1)*(x - x1) +  (y - y1)*(y - y1));
        }

        public static int gamma(int val, double gamma)
        {
            return (int)(255d * Math.Pow(val / 255d, gamma));
        }

        public static int Brighten(int color, int light)
        {
            return color + light > 255 ? 255 : color + light;
        }
        public static int Contrast(int color, int low, int high)
        {
            int ret = color < low ? 0 : (int)(color * 255f / (float)(high - low));
            return ret > 255 ? 255 : ret;
        }

        public static int binom(int n, int k)
        {
            return factorial(n) / (factorial(k) * factorial(n - k));
        }
        public static int factorial(int p, int acc = 1)
        {
            if (p == 0)
            {
                return acc;
            }
            return factorial(p - 1, acc * p);
        }
    }
}
