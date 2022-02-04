using System;

namespace ConsoleApp.Task3._14
{
    internal class Program
    {
        /*14) 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
            Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            Neticenin 60 % tap. Cavabin axirina 60 artir.
            Neticeden 18% cix.*/
        static void Main(string[] args)
        {
            Console.Write("I Ededi daxil edin: ");
            string read1 = Console.ReadLine();
            int num1 = Convert.ToInt32(read1);
            Console.Write("II Ededi daxil edin: ");
            string read2 = Console.ReadLine();
            int num2 = Convert.ToInt32(read2);
            Console.Write("III Ededi daxil edin: ");
            string read3 = Console.ReadLine();
            int num3 = Convert.ToInt32(read3);
            Console.Write("IV Ededi daxil edin: ");
            string read4 = Console.ReadLine();
            int num4 = Convert.ToInt32(read4);

            bool isSuccess = (num1 >= 100000 && num1 < 1000000 && num2 >= 100000 && num2 < 1000000 &&
                num3 >= 100000 && num3 < 1000000 && num4 >= 1000000 && num4 < 10000000);
            if (!isSuccess)
            {
                Console.WriteLine("I, II ve III eded 6 reqemli IV eded 7 reqemli olmalidir.");
                return;
            }
            int sum;
            int remainder;
            int first3Num4;
            int newNum = 1;

            num1 = num1 / 1000;
            num2 = num2 / 1000;
            num3 = num3 / 1000;
            Console.WriteLine("--------------------------------");

            sum = num1 + num2 + num3 + (num4 % 10000);
            Console.WriteLine($"{num1} + {num2} + {num3} + {num4 % 10000} = {sum}");

            first3Num4 = num4 / 10000;
            while (first3Num4 > 0)
            {
                remainder = first3Num4 % 10;
                first3Num4 = first3Num4 / 10;
                newNum = newNum * remainder;
            }
            Console.WriteLine("--------------------------------");
            sum = sum - newNum;
            Console.WriteLine($"{num1 + num2 + num3 + (num4 % 10000)} - {newNum} = {sum}");
            Console.WriteLine("--------------------------------");
            sum = sum / 100 * 60;
            Console.WriteLine($"neticenin 60 faizi: {sum}");
            Console.WriteLine("--------------------------------");
            sum = sum * 100 + 60;
            Console.WriteLine($"neticenin sonuna 60 artirilmasi: {sum}");
            Console.WriteLine("--------------------------------");
            sum = sum - (sum / 100 * 18);
            Console.WriteLine($"neticeden 18 faizin cixilmasi: {sum}");
        }
    }
}
