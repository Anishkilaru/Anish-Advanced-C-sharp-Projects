using System;

namespace method114exercise
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            methods operation = new methods();
            int num1 = 10;
            double num2 = 4.5;
            string uinput;
            uinput = Console.ReadLine();
            int uinput2;
            uinput2 = Convert.ToInt32(uinput);
            operation.methodOne(num1);
            Console.ReadLine();
            operation.methodOne(num2);
            Console.ReadLine();
            operation.methodOne(uinput2);
            Console.ReadLine();
        }
    }
}
