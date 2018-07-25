using System;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            var input = Console.ReadLine();

            var isNum = int.TryParse(input, out var num);
            if (isNum)
            {
                if (num > 0)
                {
                    Console.WriteLine("Number is positive");
                }
                else if (num < 0)
                {
                    Console.WriteLine("Number is negative");
                }
                else
                {
                    Console.WriteLine("Number is zero");
                }
            }
        }
    }
}
