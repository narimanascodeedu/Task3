using System;

namespace ConsoleApp.Task3._8
{
    /*8) Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string read = Console.ReadLine();
            int num = Convert.ToInt32(read);

            bool isSucces = num >= 100;
            if(!isSucces)
            {
                Console.WriteLine("Daxil edeceyiniz eded minimum 3 reqemli olmalidir!");
                return;
            }
            int lastNum;
            int last_3_num;

            lastNum = num % 10;
            num = num / 100;
            last_3_num = num % 10;
            num = lastNum + last_3_num;
            Console.WriteLine(num);


        }
    }
}
