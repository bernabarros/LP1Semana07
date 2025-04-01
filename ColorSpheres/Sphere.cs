using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color color;
        private int radius;
        private int thrown_times;

        public Sphere(int color_red, int color_green, int color_blue,int radius)
        {
            this.color = new Color(color_red, color_green, color_blue);
            this.radius = radius;
            thrown_times = 0;
        }

        public int Pop()
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
        public Tuple<int,int,int> GetColor()
        {
            return Tuple.Create(color.GetRed(), color.GetGreen(), color.GetBlue());
        }
        public int GetRadius()
        {
            return radius;
        }
        public int GetTimesThrown()
        {
            return thrown_times;
        }
    }
}