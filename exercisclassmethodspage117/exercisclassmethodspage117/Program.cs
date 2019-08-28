using System;

namespace exercisclassmethodspage117
{
 public   class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my class method code ");

            // Class1 subclass = new Class1(); - the requirement says to declare a class to be static, but .net core throws error while instantiating a class variable.

            Console.WriteLine("Please enter the number ");
            Class1.MethodOne(10);
            Console.ReadLine();
            Console.WriteLine("Please enter the two numbers ");
            Class1.MethodOne(10, 12);
            Console.ReadLine();

        }
    }
}
