using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Sphere red_sphere = new Sphere(255,0,0,255,20);
            Sphere blue_sphere = new Sphere(0,0,255,255,30);
            Sphere green_sphere = new Sphere(0,255,0,255,40);

            red_sphere.Throw();
            red_sphere.Pop();
            red_sphere.Throw();

            blue_sphere.Throw();
            blue_sphere.Throw();

            green_sphere.Pop();

            Console.WriteLine(red_sphere.GetColorRed());
            Console.WriteLine(red_sphere.GetRadius());
            Console.WriteLine(red_sphere.GetTimesThrown());

            Console.WriteLine(blue_sphere.GetColorBlue());
            Console.WriteLine(blue_sphere.GetRadius());
            Console.WriteLine(blue_sphere.GetTimesThrown());

            Console.WriteLine(green_sphere.GetColorGreen());
            Console.WriteLine(green_sphere.GetRadius());
            Console.WriteLine(green_sphere.GetTimesThrown());
        }
    }
}
