using System;
using System.Collections.Generic;
using System.Text;

namespace methods115exercise
{
   public class methods
    {
        public  void methodOne(int num1, int num2 = default)
        {
            Console.WriteLine("Please pass 1st number, adn 2nd number is optional");
            num1 = Convert.ToInt32(Console.ReadLine());
            

            if (num2 == default)
            {
                int total = num1 / 4;
                Console.WriteLine(total);
                Console.ReadLine();
            }
            else
            {
                num2 = Convert.ToInt32(Console.ReadLine());
                int total = (num1 + num2) / 4;
                Console.WriteLine(total);
                Console.ReadLine();
            }

        }

        
    }
}
