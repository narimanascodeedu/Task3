using System;

namespace ConsoleApp.Task3._4
{
    /*4) verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string read = Console.ReadLine();
            int num = Convert.ToInt32(read); 

            bool isSuccess = num >= 10000 && num < 100000;
            if(!isSuccess)
            {
                Console.WriteLine($"{num} ededi 5 reqemli deyil");
                return;
            }
            int firstNum = num / 10000;
            int lastNum = num % 10;
            int sum=firstNum + lastNum;
            sum = sum * sum;
            Console.WriteLine(sum);


        }
    }
}
