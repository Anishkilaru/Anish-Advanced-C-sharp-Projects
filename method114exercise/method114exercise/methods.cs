using System;
using System.Collections.Generic;
using System.Text;

namespace method114exercise
{
   public class methods
    {
        public int  methodOne(int num1)
        {
            num1 = Convert.ToInt32(Console.ReadLine());
            int total = num1 * 3;
            //Console.WriteLine(total);
            return total;
        }

        public double methodOne(double num2)
        {
            num2 = 4.5;
            double total2 = num2 / 1;
            return total2;
        }

        public int methodOne( string uinput)
        {
            uinput = Console.ReadLine();
            int uinput2;
            uinput2 = Convert.ToInt32(uinput);
            int total3 = uinput2 + 4;
            return Convert.ToInt32(total3);
           
        }
    }
}
