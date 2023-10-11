using System;

namespace _6._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(width, height));
        }
        public static double Calculate(double width, double height)
        {
            return width * height;
        }
    }
}
   

   
