using System;

namespace ConsoleAppTask3._12
{
    /*12) 2 dene 5 reqemli eded daxil et.
    I ededin reqemleri ceminin usutne
    II ededin reqemleri hasilini gel.
    Neticenin axirina I ededin en axiinci reqemini artir.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string read1 = Console.ReadLine();
            int num1 = Convert.ToInt32(read1);
            Console.Write("Ededi daxil edin: ");
            string read2 = Console.ReadLine();
            int num2 = Convert.ToInt32(read2);

            bool isSuccess = num1 >= 10000 && num1 < 100000 && num2 >= 10000 && num2 < 100000;
            if (!isSuccess)
            {
                Console.WriteLine("Daxil edilen eded 5 reqemli deyil");
                return;
            }
            int number = num1 % 10;
            int remainder;
            int sumMul;
            int sum = 0;
            int mul = 1;

            while (num1 > 0)
            {
                remainder = num1 % 10;
                num1 = (num1 - remainder) / 10;
                sum = sum + remainder;
            }
            while (num2 > 0)
            {
                remainder = num2 % 10;
                num2 = (num2 - remainder) / 10;
                mul = mul * remainder;
            }
            sumMul = sum + mul;
            Console.WriteLine($"{sum} + {mul} = {sumMul}");
            sumMul = sumMul * 10 + number;
            Console.WriteLine(sumMul);
        }
    }
}
