using System;

namespace ConsoleApp.Task3._1
{
    internal class Program
    {
        /*1) verilmish 4 reqemli ededin reqemlerinin cemini tap*/
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string read = Console.ReadLine();
            int num = Convert.ToInt32(read);
            
            bool isSuccess = num >= 1000 && num < 10000;

            if (!isSuccess)
            {
                Console.WriteLine($"{num} ededi 4 reqemli deyil");
                return;
            }
            int remainder;
            int sum = 0;

            while (num > 0)
            {
                remainder = num % 10; 
                num = (num - remainder) / 10;
                sum = sum + remainder;
            }
            
                Console.WriteLine(sum);
        }
    }
}
