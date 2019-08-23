using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is going to be switch stateemnts numbers execise, guess a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 35;
            do
            {
                switch (number)
                {
                    case 24:
                        Console.WriteLine("24 enti ra erri pooka;");
                        Console.WriteLine("This is going to be switch stateemnts numbers execise, guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("12 aithe correct ye ra rei");
                        Console.WriteLine("This is going to be switch stateemnts numbers execise, guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 56:
                        Console.WriteLine("56 is the number you guessed");
                        Console.WriteLine("This is going to be switch stateemnts numbers execise, guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 35:
                        Console.WriteLine("You are correct 35 is what I am looking for");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Keep trying my friend, you will reach it");
                        Console.WriteLine("This is going to be switch stateemnts numbers execise, guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;


                }

            }
            while (!isGuessed);
            {
                switch (number)
                {
                    case 24:
                        Console.WriteLine("24 enti ra erri pooka;");
                        Console.WriteLine("This is going to be switch stateemnts numbers execise, guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("12 aithe correct ye ra rei");
                        Console.WriteLine("This is going to be switch stateemnts numbers execise, guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 56:
                        Console.WriteLine("56 is the number you guessed");
                        Console.WriteLine("This is going to be switch stateemnts numbers execise, guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 35:
                        Console.WriteLine("You are correct 35 is what I am looking for");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Keep trying my friend, you will reach it");
                        Console.WriteLine("This is going to be switch stateemnts numbers execise, guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;


                }
            }
            
            Console.ReadLine();
        }
    }
}
