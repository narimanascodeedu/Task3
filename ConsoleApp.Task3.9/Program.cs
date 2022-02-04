using System;

namespace ConsoleApp.Task3._9
{
    /*9) 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string read = Console.ReadLine();
            int num = Convert.ToInt32(read);

            bool isSuccess = num >= 100000000 && num < 1000000000;
            if (!isSuccess)
            {
                Console.WriteLine($"{num} ededi 9 reqemli deyil");
                return;
            } 
            int newNum;   
            int remainder;
            int counter;  
            newNum = 0;   
            counter = 1;  

            while (num > 0)
            {
                remainder = num % 10;
                num = num / 10;

                if (counter % 2 != 0)
                {
                    newNum = newNum * 10 + remainder;
                }
                counter++;
            }
            num = newNum;   
            newNum = 0;     
            while (num > 0)
            {
                remainder = num % 10;
                num = num / 10;
                newNum = newNum * 10 + remainder;
            }
            Console.WriteLine(newNum);

        }
    }
}
