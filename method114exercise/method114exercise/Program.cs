using System;

namespace method114exercise
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            methods operation = new methods();
            
            double num2 = 4.5;
            string uinput;
            uinput = Console.ReadLine();
            int uinput2;
            uinput2 = Convert.ToInt32(uinput);
            operation.methodOne(10);
            operation.methodFour(3.4M);
            Console.ReadLine();
            operation.methodOne(num2);
            Console.ReadLine();
            operation.methodOne(uinput2);
            Console.ReadLine();
        }
    }
}
