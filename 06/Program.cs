using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = 7.5;
            Console.WriteLine($"Perimeter is = {2 * Math.PI * radius}");
            Console.WriteLine($"Area is = {Math.PI * Math.Pow(radius, 2)}");
        }
    }
}
