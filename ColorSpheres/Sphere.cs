using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color color;
        private float radius;
        private int thrown_times;

        public Sphere(byte color_red, byte color_green, byte color_blue
        , byte alpha, byte radius)
        {
            this.color = new Color(color_red, color_green, color_blue, alpha);
            this.radius = radius;
            thrown_times = 0;
        }

        public float Pop()
        {
            return radius = 0;
        }
        public int Throw()
        {
            if(radius > 0)
            {
                thrown_times++;
            }
            return thrown_times;
        }
        public byte GetColorRed()
        {
            return color.GetRed();
        }
        public byte GetColorGreen()
        {
            return color.GetGreen();
        }
        public byte GetColorBlue()
        {
            return color.GetBlue();
        }
        public byte GetColorAlpha()
        {
            return color.GetAlpha();
        }
        public byte GetColorGrey()
        {
            return color.GetGrey();
        }
        public float GetRadius()
        {
            return radius;
        }
        public int GetTimesThrown()
        {
            return thrown_times;
        }
    }
}