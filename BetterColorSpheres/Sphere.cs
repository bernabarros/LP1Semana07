using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        private readonly Color color;
        private float radius;
        private int times_thrown;
        public Sphere(byte inputred, byte inputgreen, byte inputblue, 
        byte inputalpha, float radius)
        {
            color = new Color(inputred, inputgreen, inputblue, inputalpha);
            this.radius = radius;
            times_thrown = 0;
        }
        public byte GetColorRed()
        {
            return color.Red;
        }
        public byte GetColorGreen()
        {
            return color.Green;
        }
        public byte GetColorBlue()
        {
            return color.Blue;
        }
        public byte GetColorAlpha()
        {
            return color.Alpha;
        }
        public byte GetColorGrey()
        {
            return color.Grey;
        }
        public float GetRadius()
        {
            return radius;
        }
        public float Pop()
        {
            return radius = 0;
        }
        public int Throw()
        {
            if(radius > 0)
            {
                times_thrown++;
            }
            return times_thrown;
        }
        
        public int GetTimesThrown()
        {
            return times_thrown;
        }
    }
}