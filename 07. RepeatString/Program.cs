using System;
using System.Text;

namespace _07._RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string templete = Console.ReadLine();
            int repates = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(templete, repates));
        }
        static string RepeatString(string template, int repates)
        {
            StringBuilder stringBuilder = new StringBuilder(); // never create new string, but make massiv string!!! faster
            for (int i = 0; i < repates; i++)
            {
                stringBuilder.Append(template);
            }
            return stringBuilder.ToString();
        }
    }
}
        
