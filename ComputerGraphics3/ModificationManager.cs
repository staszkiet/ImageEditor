using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics3
{
    public abstract class ModificationManager
    {
        public abstract Color ModifyPixel(Color c);

    }

    public class NothingManager : ModificationManager
    {
        public override Color ModifyPixel(Color r)
        {
            return r;
        }
    }
    public class NegationManager : ModificationManager
    {
        public override Color ModifyPixel(Color r)
        {
            return Color.FromArgb(255 - r.R, 255 - r.G, 255 - r.B);
        }
    }

    public class BrightnessManager : ModificationManager
    {
        public static int light = 100;
        public override Color ModifyPixel(Color r)
        {
            return Color.FromArgb(Helpers.Brighten(r.R, light), Helpers.Brighten(r.G, light), Helpers.Brighten(r.B, light));
        }
    }

    public class ContrastManager : ModificationManager
    {
        public static int contrast_low = 55;
        public static int constrast_high = 200;
        public override Color ModifyPixel(Color c)
        {
            return Color.FromArgb(Helpers.Contrast(c.R, contrast_low, constrast_high), Helpers.Contrast(c.G, contrast_low, constrast_high), Helpers.Contrast(c.B, contrast_low, constrast_high));
        }
    }
    public class GammaManager : ModificationManager
    {
        public static double gamma = 2d;
        public override Color ModifyPixel(Color r)
        {
            return Color.FromArgb(Helpers.nigamma(r.R, gamma), Helpers.nigamma(r.G, gamma), Helpers.nigamma(r.B, gamma));
        }
    }

    public class CustomManager : ModificationManager
    {
        public static Dictionary<int, int> mapping;

        public override Color ModifyPixel(Color r)
        {
            return Color.FromArgb(mapping[r.R], mapping[r.G], mapping[r.R]);
        }
    }
}
