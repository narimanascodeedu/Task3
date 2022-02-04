using System;

namespace ConsoleApp.Task3._13
{
    /*13) 3 dene 5 reqemli eded var.
    Her bir  ededin ilk ve son reqemlerininden 
    1 eded duzlet. Alinan neticeleri topla
    Yekunda alian cavabin 50%-ni hemin ededin uzerine gel*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("I ededi daxil edin: ");
            string read1 = Console.ReadLine();
            int num1 = Convert.ToInt32(read1);
            Console.Write("II ededi daxil edin: ");
            string read2 = Console.ReadLine();
            int num2 = Convert.ToInt32(read2);
            Console.Write("III ededi daxil edin: ");
            string read3 = Console.ReadLine();
            int num3 = Convert.ToInt32(read3);

            int newNum1;
            int newNum2;
            int newNum3;
            int sum;

            bool isSuccess = (num1 >= 10000 && num1 < 100000 &&

                num2 >= 10000 && num2 < 100000 && num3 >= 10000 && num3 < 100000);
            if (!isSuccess)
            {
                Console.WriteLine("Daxil edilen ededlerden bir veya bir necesi 5 reqemli deyil.");
                return;
            }

            newNum1 = (num1 / 10000) * 10 + (num1 % 10);
            newNum2 = (num2 / 10000) * 10 + (num2 % 10);
            newNum3 = (num3 / 10000) * 10 + (num3 % 10);
            sum = newNum1 + newNum2 + newNum3;

            Console.WriteLine(newNum1);
            Console.WriteLine(newNum2);
            Console.WriteLine(newNum3);
            Console.WriteLine($"{newNum1} + {newNum2} + {newNum3} = {sum}");
            Console.WriteLine($"{sum} + {sum / 100 * 50} = {sum + (sum / 100 * 50)}");
        }
    }
}
