using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            var input = Console.ReadLine();
            var isNum =  int.TryParse(input, out var num);

            if (isNum)
            {
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{num} x {i + 1} = {num * (i + 1)}");
                }
            }
        }
    }
}
