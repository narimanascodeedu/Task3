using System;

namespace ConsoleAppTask3._7
{
    /*7) verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string read=Console.ReadLine();
            int num = Convert.ToInt32(read);

            bool isSuccess = num >= 1000 && num < 10000;
            if(!isSuccess)
            {
                Console.WriteLine($"{num} ededi 4 reqemli deyil");
                return;
            }
            int newNum;    
            int remainder;  
            num = num * 10 + 8; 
            newNum = 0;     

            while (num > 0)
            {
                remainder= num % 10;
                newNum = newNum * 10 + remainder;
                num = num / 10;
            }
            newNum = newNum * 10 + 8;
            Console.WriteLine(newNum);


        }
    }
}
