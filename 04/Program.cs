using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            var x = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            var y = int.Parse(Console.ReadLine());

            Console.WriteLine($"{x} x {y} = {x*y}");
        }
    }
}
