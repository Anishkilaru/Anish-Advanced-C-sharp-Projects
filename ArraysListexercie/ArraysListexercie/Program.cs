using System;
using System.Collections.Generic;

    class Program
    {
    /// <summary>
    /// Add's user input as a text to the string array and prints out after adding the text to the string array.
    /// 
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
        Console.WriteLine("Welcome to my ArraysList exercise passionate coder: ");
        Console.WriteLine("Please type 4 names");

        String[] text = { "Whos is a legend", (Console.ReadLine()), "Who scores 100", (Console.ReadLine()), "who loves more", (Console.ReadLine()), "who is the actor", (Console.ReadLine()) };


        Console.WriteLine("Here are your answeres respectively");
        foreach (string input in text)
        {
            Console.WriteLine(input);
        }
        Console.ReadLine();

        //Infinite loop
        int[] numbers = { 12, 34, 5, 6, 7, 8, 9, 90, 54, 3, 76, 89, 04, 6 };
        while (numbers.Length > 6)
        {
            Console.WriteLine("Ayyav le pedda erri pooku ");

        }
        Console.ReadLine();


        //fixed infinite loop
        int[] numbers5 = { 12, 34, 5, 6, 7, 8, 9, 90, 54, 3, 76, 89, 04, 6 };
        int lenghtentha5 = numbers.Length;
        if (numbers.Length.Equals(lenghtentha5))
        {
            Console.WriteLine("Ayyav le pedda erri pooku ");

        }
        Console.ReadLine();


        //loop with < comparison
        int[] numbers1 = { 12, 34, 5, 6, 7, 8, 9, 90, 54, 3, 76, 89, 04, 6 };
        int lenghtentha1 = 6;
        if (numbers.Length < lenghtentha1)
        {
            Console.WriteLine("Ayyav le pedda erri pooku ");

        }
        else
        {
            Console.WriteLine("This program is success");
        }

        Console.ReadLine();

        // Loop with <= comparison
        int[] numbers2 = { 12, 34, 5, 6, 7, 8, 9, 90, 54, 3, 76, 89, 04, 6 };
        int lenghtentha2 = 14;
        if (numbers.Length <= lenghtentha2)
        {
            Console.WriteLine("Ayyav le pedda erri pooku ");

        }
        else
        {
            Console.WriteLine("This program is success");
        }

        Console.ReadLine();

        //list of string #6 point in exercise page 103.
        List<String> names = new List<string>() { "MARS", "PLUTO", "VENUS", "EARTH", "JUPITER" };

        Console.WriteLine("Type in a planet name so we will search in the list");

        String uinput = (Console.ReadLine()).ToUpperInvariant();

        foreach (string usertyped in names)
        {
            if (uinput == usertyped)
            {
                int display = Convert.ToInt32(names.IndexOf(usertyped));
                Console.WriteLine("Index of your selected text is :" + display);
            }

        }

        Console.ReadLine();


        //list of string #7 point in exercise page 103.
        List<String> names1 = new List<string>() { "MARS", "PLUTO", "VENUS", "EARTH", "JUPITER" };

        Console.WriteLine("Type in a planet name so we will search in the list");

        String uinput1 = (Console.ReadLine()).ToUpperInvariant();

        foreach (string usertyped1 in names)
        {
            if (uinput1 == usertyped1)
            {
                int display1 = Convert.ToInt32(names.IndexOf(usertyped1));
                Console.WriteLine("Index of your selected text is :" + display1);
            }

            else
            {
                Console.WriteLine("Sorry, the selected planet doesn't exist in the current list.");
                Console.ReadLine();
            }
        }

        Console.ReadLine();


        //list of string #8 point in exercise page 103.
        List<String> names4 = new List<string>() { "MARS", "PLUTO", "VENUS", "EARTH", "JUPITER" };

        Console.WriteLine("Type in a planet name so we will search in the list");

        String uinput4 = (Console.ReadLine()).ToUpperInvariant();

        foreach (string usertyped4 in names4)
        {
            if (uinput4 == usertyped4)
            {
                int display = Convert.ToInt32(names.IndexOf(usertyped4));
                Console.WriteLine("Index of your selected text is :" + display);
            }

            else
            {
                Console.WriteLine("Sorry, the selected planet doesn't exist in the current list.");
                Console.ReadLine();
            }
        }

        Console.ReadLine();

        //list of string #9 point in exercise page 103. This won't work and I need some help
        List<String> names5 = new List<string>() { "MARS", "PLUTO", "VENUS", "EARTH", "MARS" };

        Console.WriteLine("Type in a planet name so we will search in the list");

        String uinput5 = (Console.ReadLine()).ToUpperInvariant();


        foreach (string usertyped5 in names5)
        {

            if (uinput5 == usertyped5)
            {

                var display = names.FindIndex(a => a == usertyped5);
                Console.WriteLine("Index of your selected text is :" + display);
            }

            else
            {
                Console.WriteLine("Sorry, the selected planet doesn't exist in the current list.");
                Console.ReadLine();
            }
        }

        Console.ReadLine();



    }
}
