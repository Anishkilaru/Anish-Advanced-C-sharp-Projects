using System;
using System.Collections.Generic;

namespace ArrayListexercise
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = { "Sai", "Venkatesh", "Anish", "Patel", "Dharti" };

            Console.WriteLine("Please select the index of the array from 0 to 4");
            int userinput = Convert.ToInt32(Console.ReadLine());

            if(userinput == 0)
            {
                Console.WriteLine(text[0]);
                Console.ReadLine();
            }
            if (userinput == 1)
            {
                Console.WriteLine(text[1]);
                Console.ReadLine();
            }
            if (userinput == 2)
            {
                Console.WriteLine(text[2]);
                Console.ReadLine();
            }
            if (userinput == 3)
            {
                Console.WriteLine(text[3]);
                Console.ReadLine();
            }
            if (userinput == 4)
            {
                Console.WriteLine(text[4]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry sir, that array doesn't exist");
                Console.ReadLine();
            }

            Console.WriteLine("Welcome to my Integer array world");
            Console.WriteLine("Please select the index of the array from 0 to 3");
            int[] numbers = { 100, 200, 300, 400 };

            userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput == 0)
            {
                Console.WriteLine(numbers[0]);
                Console.ReadLine();
            }
            if (userinput == 1)
            {
                Console.WriteLine(numbers[1]);
                Console.ReadLine();
            }
            if (userinput == 2)
            {
                Console.WriteLine(numbers[2]);
                Console.ReadLine();
            }
            if (userinput == 3)
            {
                Console.WriteLine(numbers[3]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry sir, that array doesn't exist");
                Console.ReadLine();
            }

            List<String> familyTree = new List<string> { "Kishore", "Patuu", "Suryudu" };

            Console.WriteLine("Welcome to my List world");
            Console.WriteLine("Please select the index of the list from 0 to 2");

            userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput == 0)
            {
                Console.WriteLine(familyTree[0]);
                Console.ReadLine();
            }
            if (userinput == 1)
            {
                Console.WriteLine(familyTree[1]);
                Console.ReadLine();
            }
            if (userinput == 2)
            {
                Console.WriteLine(familyTree[2]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry sir, that array doesn't exist");
                Console.ReadLine();
            }




        }
    }
}
