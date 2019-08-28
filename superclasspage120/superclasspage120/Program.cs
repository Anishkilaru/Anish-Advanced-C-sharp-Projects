using System;
using System.Collections.Generic;

namespace superclasspage120
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my main super classs method friend ");

            Employee emp = new Employee() { Firstname = "Sample", Lastname = "Student" };
            emp.SayName();
            Console.ReadLine();
        }
    }
}
