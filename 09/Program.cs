using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            var input1 = Console.ReadLine();
            Console.Write("Input second number: ");
            var input2 = Console.ReadLine();
            Console.Write("Input third number: ");
            var input3 = Console.ReadLine();

            var isNum1 = int.TryParse(input1, out var num1);
            var isNum2 = int.TryParse(input2, out var num2);
            var isNum3 = int.TryParse(input3, out var num3);

            if (isNum1 && isNum2 && isNum3)
            {
                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine($"The greatest: {num1}");
                    }
                }
                else if (num2 > num1)
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine($"The greatest: {num2}");
                    }
                }
                else if (num3 > num1)
                {
                    if (num3 > num2)
                    {
                        Console.WriteLine($"The greatest: {num3}");
                    }
                }
            }
        }
    }
}
