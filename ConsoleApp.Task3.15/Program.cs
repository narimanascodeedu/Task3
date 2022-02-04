using System;

namespace ConsoleApp.Task3._15
{
    /*15)* 5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
     3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
     Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
     Cavabdan 7 reqemli ededin son 5 reqemini cix.
     Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
     Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
     Cavabin axirina 11 artir.
     Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
     Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("(eded 3 reqemden ibaret olmalidir)I Ededi daxil edin:");
            string read1 = Console.ReadLine();
            int num1 = Convert.ToInt32(read1);
            Console.Write("(eded 3 reqemden ibaret olmalidir)II Ededi daxil edin:");
            string read2 = Console.ReadLine();
            int num2 = Convert.ToInt32(read2);
            Console.Write("(eded 6 reqemden ibaret olmalidir)III Ededi daxil edin:");
            string read3 = Console.ReadLine();
            int num3 = Convert.ToInt32(read3);
            Console.Write("(eded 6 reqemden ibaret olmalidir)IV Ededi daxil edin:");
            string read4 = Console.ReadLine();
            int num4 = Convert.ToInt32(read4);
            Console.Write("(eded 7 reqemden ibaret olmalidir)V Ededi daxil edin:");
            string read5 = Console.ReadLine();
            int num5 = Convert.ToInt32(read5);

            bool isSuccess = (num1 >= 100 && num1 < 1000 && num2 >= 100 && num2 < 1000 && num3 >= 100000 && num3 < 1000000 &&
                num4 >= 100000 && num4 < 1000000 && num5 >= 1000000 && num5 < 10000000);
            if (!isSuccess)
            {
                Console.WriteLine("Ededlerin bir veya bir necesinin sayi duzgun daxil edilmeyib. ");
            }

            int sumDdigits3;
            int stickDigits3;
            int sumDigits6;
            int digit7last5;
            int sumDigit7revers;
            int remainder;
            int newNum;
            int counter = 1;

            sumDdigits3 = num1 + num2;
            Console.WriteLine($"3 reqemli ededlerin cemi: {num1} + {num2} = {sumDdigits3}");
            Console.WriteLine($"3 reqemli ededlerin ceminin sondan 2 reqeminin kvadrati: " +
                $"{sumDdigits3 % 100} * {sumDdigits3 % 100} = {(sumDdigits3 % 100) * (sumDdigits3 % 100)}");
            sumDdigits3 = (sumDdigits3 % 100) * (sumDdigits3 % 100);
            stickDigits3 = num1 * 1000 + num2;
            Console.WriteLine($"3 reqemli ededlerin bir birine yapismasi: {stickDigits3}");
            Console.WriteLine($"3 reqemli ededlerin ceminin sondan 2 ededinin kvadrati ile 3reqemli ededlerin bir birine yapismasinin cemi: " +
                $"{sumDdigits3} + {stickDigits3} = {sumDdigits3 + stickDigits3}");
            sumDdigits3 = sumDdigits3 + stickDigits3;
            digit7last5 = num5 % 100000;
            Console.WriteLine($"alinan cavabdan 7 reqemli ededin son 5 reqemini cix: {sumDdigits3} - {digit7last5} = {sumDdigits3 - digit7last5}");
            sumDdigits3 = sumDdigits3 - digit7last5;
            Console.WriteLine($"alinan cavabin uzerine 6 reqemli ededlerin ceminden son 3 reqemini gel {num3} + {num4} = {num3 + num4}-----{(num3 + num4) % 1000}");
            sumDigits6 = (num3 + num4) % 1000;
            Console.WriteLine($"{sumDdigits3} + {sumDigits6} = {sumDdigits3 + sumDigits6}");
            sumDdigits3 = sumDdigits3 + sumDigits6; 
            sumDigit7revers = 0;
            newNum = num5;
            while (newNum > 0)
            {
                remainder = newNum % 10;
                newNum = (newNum - remainder) / 10;
                sumDigit7revers = sumDigit7revers + remainder;
            }
            newNum = sumDigit7revers;
            sumDigit7revers = 0;
            while (newNum > 0)
            {
                remainder = newNum % 10;
                newNum = (newNum - remainder) / 10;
                sumDigit7revers = sumDigit7revers * 10 + remainder;
            }
            Console.WriteLine($"7 reqemli ededin: {num5} ededleri ceminin tersine yazilmis formasi: {sumDigit7revers}");
            Console.WriteLine($"neticenin uzerine 7 reqemli ededin ededleri ceminin tersine yazilmis formasini gel: " +
                $"{sumDdigits3} + {sumDigit7revers} = {sumDdigits3 + sumDigit7revers}");
            sumDdigits3 = sumDdigits3 + sumDigit7revers;
            sumDdigits3 = sumDdigits3 * 100 + 11;
            Console.WriteLine($"cavabin axirina 11 artirilmasi: {sumDdigits3}");

            while (num5 > 0)
            {
                remainder = num5 % 10;
                num5 = (num5 - remainder) / 10;
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
                num5 = num5 * 10 + remainder;
            }
            Console.WriteLine($"neticeden 7 reqemli ededin tek yerde dayanan reqemlerinden alinan ededi cix: {sumDdigits3} - {num5} = {sumDdigits3 - num5}");
            sumDdigits3 = sumDdigits3 - num5; 
            newNum = sumDdigits3 % 10;
            sumDdigits3 /= 10;
            sumDdigits3 = sumDdigits3 * 100 + 88;
            sumDdigits3 = sumDdigits3 * 10 + newNum;
            Console.WriteLine($"neticenin axirdan II reqemi ile axirinci reqemin arasina 88 elave et: {sumDdigits3}");

            
        }
    }
}
