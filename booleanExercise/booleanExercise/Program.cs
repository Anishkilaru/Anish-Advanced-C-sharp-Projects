using System;

namespace booleanExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? ");

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);

            Console.WriteLine("Have you ever had a DUI? ");

            bool answer = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine(answer);

            Console.WriteLine("How many speeding tickets do you have");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(tickets);



            bool rate = age > 15 && answer == false  && tickets <= 3;
            Console.WriteLine("Qualified? ");
            Console.WriteLine(rate);

            Console.ReadLine();
     

        }
    }
}
