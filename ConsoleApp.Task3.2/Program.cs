using System;

namespace ConsoleApp.Task3._2
{
    internal class Program
    {
        /*2) verilmihs 6 reqemli ededin ilk 3 denesinin
         * reqemleri cemi tap: example: 123600= 1+2+3*/
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
            num = (num - (num % 1000)) / 1000;
            int remainder;
            int sum = 0;
            while (num > 0)
            {
                remainder = num % 10;
                num=(num- remainder) / 10;
                sum=sum + remainder;
            }
            Console.WriteLine(sum);

        }
    }
}
