using System;

namespace ConsoleApp.Task3._10
{
    internal class Program
    {
        /*10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
         sonra cut yerde dayanlarinda bir eded duzlet,
         sonra onlari topla*/
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string read = Console.ReadLine();
            int num = Convert.ToInt32(read);

            bool isSuccess = num >= 100000000 && num < 1000000000;
            if(!isSuccess)
            {
                Console.WriteLine($"{num} ededi 9 reqemli deyil");
                return;
            }
            int oddNum = num;
            int evenNum = num;
            int sumOddEven;
            int remainder;
            int newNum = 0; 
            int counter = 1; 

            while (oddNum > 0)
            {
                remainder = oddNum % 10;
                oddNum = (oddNum - remainder) / 10;
                if (counter % 2 != 0)
                {
                    newNum = newNum * 10 + remainder;
                }
                counter++;
            }
            while (newNum > 0)
            {
                remainder = newNum % 10;
                newNum = (newNum - remainder) / 10;
                oddNum = oddNum * 10 + remainder;
            }                     
            while (evenNum > 0)  
            {
                remainder = evenNum % 10;
                evenNum = (evenNum - remainder) / 10;
                if (counter % 2 != 0)
                {
                    newNum = newNum * 10 + remainder;
                }
                counter++;
            }
            while (newNum > 0)
            {
                remainder = newNum % 10;
                newNum = (newNum - remainder) / 10;
                evenNum = evenNum * 10 + remainder;
            }
            sumOddEven = oddNum + evenNum;
            Console.WriteLine($"{oddNum} + {evenNum} = {sumOddEven}");
        }
    }
}
