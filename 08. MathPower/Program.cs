using System;

namespace _08._MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(PrintPowerNumberBase(baseNumber, power));
        }
        static double PrintPowerNumberBase(double baseNumber, double power)
        {
            return Math.Pow(baseNumber, power);
        }
    }
}
        
