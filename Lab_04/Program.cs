//It's a task from 13.11.2021.

using System;

namespace Lab_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string s0 = " Our Princess Is In Another Castle! ";

            string s1 = s0.ToUpper();
            string s2 = s0.ToLower();
            string s3 = s0.Trim();

            string s4 = s3.Substring(16);
            string s5 = s3.Substring(4, 8);

            string[] a6 = s3.Split();
            char[] a7 = s3.ToCharArray();

            int i8 = s3.IndexOf('e');
            int i9 = s3.LastIndexOf('e');

            if (s3.StartsWith("Our"))
                Console.WriteLine("Our");

            if (s3.Contains("Princess"))
                Console.WriteLine("Princess!");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(a6.Length);
            Console.WriteLine(a7.Length);
            Console.WriteLine(i8);
            Console.WriteLine(i9);
        }
    }
}
