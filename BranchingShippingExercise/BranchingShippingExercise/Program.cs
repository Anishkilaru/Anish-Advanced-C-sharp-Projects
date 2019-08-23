using System;

namespace BranchingShippingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Package weight? ");

            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight < 50)
            {
                Console.WriteLine("Package Width?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Package height? ");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Package Length?");
                int length = Convert.ToInt32(Console.ReadLine());
                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped by Express.");
                    Console.ReadLine();
                }

                else
                {
                    double total = (width + length + height) / 100.0;
                    Console.WriteLine("Your quote is: $$ " + total);
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Express. Have a good day.");
                Console.ReadLine();
            }
        }
    }
}
