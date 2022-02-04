using System;

namespace ConsoleApp.Task3._11
{
    internal class Program
    {
        /*11) 8 reqemli ededin reqemlerini iki -iki qruplashdir.
            Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
            Sonra cavabin ozunden onun 18% ni cix;*/
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string read = Console.ReadLine();
            int num = Convert.ToInt32(read);

            bool isSuccess = num >= 10000000 && num < 100000000;
            if (!isSuccess)
            {
                Console.WriteLine("Eded 8 reqemli deyil");
                return;
            }
            int remainder;
            int sumLast99;
            int sumPer18;
            int sum = 0;

            while (num > 0)
            {
                remainder = num % 100;
                num = num / 100;
                sum = sum + remainder;
            }
            Console.WriteLine($"iki-iki qruplasmis ededlerin toplami: {sum}");
            sumLast99 = sum * 100 + 99;
            Console.WriteLine($"Ededin sonuna 99 yazilmasi: {sumLast99}");
            sumPer18 = sumLast99 / 100 * 18;
            Console.WriteLine($"{sumLast99} ededinin 18 faizi: {sumPer18}");
            sum = sumLast99 - sumPer18;
            Console.WriteLine($"{sumLast99} - {sumPer18} = {sum}");
        }
    }
}
