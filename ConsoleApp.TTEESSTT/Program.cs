using System;

namespace ConsoleApp.TTEESSTT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234567;
            a = a % 100000;
            Console.WriteLine(a);
        }
    }
}
