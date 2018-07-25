using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random rand = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
                Console.WriteLine(array[i]);
            }
        }
    }
}
