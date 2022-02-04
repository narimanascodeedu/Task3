using System;

namespace ConsoleApp.Task3._6
{
    /*6) verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string read = Console.ReadLine();
            int num = Convert.ToInt32(read);

            bool isSuccess = num >= 10000000 && num < 100000000;
            if (!isSuccess)
            {
                Console.WriteLine($"{num} ededi 8 reqemli deyil");
                return;
            }
            int newNum;       
            int remainder;   
            num = num / 10;  
            newNum = 0;      

            while (num > 0)
            {
                remainder = num % 10;
                newNum = newNum * 10 + remainder;
                num = num / 10;
            }
            num = newNum; 
            newNum = 0; 
            num = num / 10;
            while (num > 0)
            {
                remainder = num % 10;
                newNum = newNum * 10 + remainder;
                num = num / 10;
            }
            Console.WriteLine(newNum);
        }
    }
}
