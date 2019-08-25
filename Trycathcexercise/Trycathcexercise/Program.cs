using System;
using System.Collections.Generic;

namespace Trycathcexercise
{
    class Program
    {
        /// <summary>
        /// Try catch block, with happy path which is non-zero numbers, and exception handling.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {

                // Enter user input as a string.
                Console.WriteLine("Welcome to my try catch program ");

                List<int> numbers2 = new List<int>() { 4, 8, 12, 16 };

                Console.WriteLine("Please enter Anish as the number ");

                int uinputs2 = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numbers2.Count; i++)
                {
                    int total2 = Convert.ToInt32(numbers2[i]) / uinputs2;
                    Console.WriteLine("All the resulst are " + total2);
                }
                Console.ReadLine();
               


               // Enter user input as zero. Please comment lines 18 to 31 for the program to run this code with user input as zero.

                Console.WriteLine("Welcome to my try catch program ");

                List<int> numbers1 = new List<int>() { 4, 8, 12, 16 };

                Console.WriteLine("Please enter zero as the number ");

                int uinputs1 = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numbers1.Count; i++)
                {
                    int total1 = Convert.ToInt32(numbers1[i]) / uinputs1;
                    Console.WriteLine("All the resulst are " + total1);
                }
                Console.ReadLine();

               

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Please hit enter and I will continue the program without hardstop.");
                Console.ReadLine();
                // Enter user input as a string.
                Console.WriteLine("Welcome to my try catch program ");

                List<int> numbers = new List<int>() { 4, 8, 12, 16 };

                Console.WriteLine("Please enter a number ");

                int uinputs = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numbers.Count; i++)
                {
                    int total = Convert.ToInt32(numbers[i]) / uinputs;
                    Console.WriteLine("All the resulst are " + total);
                }
                Console.ReadLine();
            }



        }
    }
}
