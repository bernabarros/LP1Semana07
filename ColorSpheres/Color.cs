using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private readonly byte red;
        private readonly byte green;
        private readonly byte blue;
        private readonly byte alpha;
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public byte GetRed()
        {
            return red;
        }
        public byte GetGreen()
        {
            return green;
        }
        public byte GetBlue()
        {
            return blue;
        }
        public byte GetAlpha()
        {
            return alpha;
        }
        public byte GetGrey()
        {
            byte grey;

            grey = (byte)((red + green + blue) / 3);
            return grey;
        }
    }
}