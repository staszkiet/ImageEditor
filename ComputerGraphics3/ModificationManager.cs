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

    public class NegationManager : ModificationManager
    {
        public override Color ModifyPixel(Color r)
        {
            return Color.FromArgb(255 - r.R, 255 - r.G, 255 - r.B);
        }
    }
}
