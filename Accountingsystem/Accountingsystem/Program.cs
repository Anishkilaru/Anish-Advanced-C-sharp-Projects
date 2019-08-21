using System;

namespace Accountingsystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to ACme Accounting Systems");
            Console.WriteLine("Remember, we're accounting on you!");
        

            decimal moneyInbanl = 100.5m;

            String Name = "Munda" + moneyInbanl;
            Console.WriteLine(Name);
            Console.ReadKey();

            String yearsOld = "12";
            int currentAge = Convert.ToInt32(yearsOld);

            int currentAges = 12;

            String nijamaOld = Convert.ToString(currentAges);


            bool isRainin = true;
            String isRainstatus = isRainin.ToString();



        }
    }
}
