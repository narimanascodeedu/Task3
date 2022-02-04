using System;

namespace ConsoleAppTask3._3
{
    internal class Program
    {
        /*3) verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi*/
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string read = Console.ReadLine();
            int num = Convert.ToInt32(read); //123456789

            bool isSuccess = num >= 100000000 && num < 1000000000;
            if (!isSuccess)
            {
                Console.WriteLine($"{num} ededi 9 reqemli deyil");
                return;
            }

            int remainder;
            int sum = 0;

            num = num / 1000;
            num = num % 1000;
            
            while (num > 0) //456
            {
                remainder = num % 10;
                num = num / 10;
                sum = remainder + sum;
            }
            Console.WriteLine(sum);

        }
    }
}
