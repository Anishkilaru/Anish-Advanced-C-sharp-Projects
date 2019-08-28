using System;
using System.Collections.Generic;
using System.Text;

namespace exercisclassmethodspage117
{
    public static class Class1
    {
        public static int MethodOne(int num1)
        {
            num1 = Int32.Parse(Console.ReadLine());

            int total = num1 / 2;
            Console.WriteLine(total);
            Console.ReadLine();
            return total;
         
            
        }

        public static int MethodOne(int num1, int num2)
        {
            num1 = Int32.Parse(Console.ReadLine());
            num2 = 10;

            int total = num1 / num2;
            Console.WriteLine(total);
            Console.ReadLine();
            return total;
        }

    }
}
