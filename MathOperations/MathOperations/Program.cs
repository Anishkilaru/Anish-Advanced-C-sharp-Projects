using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {


            int totall = 5 + 67;
            Console.WriteLine("Five + Sixty Seven =" + totall.ToString());

            double quotient = 86 / 5.0;
            Console.WriteLine(quotient);
            Console.ReadLine();

            int remainder = 17 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 78;

            bool isWarm = currentTemperature > roomTemperature;
            Console.WriteLine(isWarm.ToString());
            Console.ReadLine();








            int num1 = 12;
            int num2 = 18;

            int total = num1 + num2;

            Console.WriteLine(total);
            Console.ReadLine();

            int a = 14;
            double b = 12.4;

            int totalc = a + Convert.ToInt32(b);

            Console.WriteLine(totalc);

            double d = 154;
            float e = 8.6f;

            double totalf = d + e;

            Console.WriteLine(totalf);

            float g = 23.7f;
            int h = 10;

            double totalj = g + h;

            decimal k = 3674873.58969m;
            sbyte l = 36;

            decimal totalm = k + l;

            Console.WriteLine("Ipudu chudu na kodaka..........");

            Console.WriteLine(totalm);

            String name = "danemmalanza";
            int number = 23545;

            Console.WriteLine(name + number);
            Console.ReadLine();

        }
    }
}
