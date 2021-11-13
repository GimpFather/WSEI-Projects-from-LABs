//It's a task from 13.11.2021.

using System;

namespace Lab_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 18, 8, 9, 4 };

            foreach( int num in numbers)
            {
                double x = Math.Pow(num, 2);
                Console.WriteLine(num + "^2 = " + x);
            }
        }
    }
}
