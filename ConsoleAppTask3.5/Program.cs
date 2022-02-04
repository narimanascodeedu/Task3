using System;

namespace ConsoleAppTask3._5
{
    /*5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string read = Console.ReadLine();
            int num = Convert.ToInt32(read);

            bool isSuccess = num >= 100000 && num < 1000000;

            if (!isSuccess)
            {
                Console.WriteLine($"{num} ededi 6 reqemli deyil");
                return;
            }
            int firstNum;
            firstNum = num / 100000;
            num = num * 10 + firstNum;
            Console.WriteLine(num);

        }
    }
}
