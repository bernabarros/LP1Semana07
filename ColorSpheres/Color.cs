using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private readonly int red;
        private readonly int green;
        private readonly int blue;
        private readonly int alpha;
        private const int alpha_value = 255;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = alpha_value;
        }

        public int GetRed()
        {
            return red;
        }
        public int GetGreen()
        {
            return green;
        }
        public int GetBlue()
        {
            return blue;
        }
        public int GetGrey()
        {
            int grey;

            grey = (red + green + blue) / 3;
            return grey;
        }
    }
}