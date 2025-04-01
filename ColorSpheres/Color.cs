using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
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