using System;
using System.Collections.Generic;
using System.Text;

namespace superclasspage120
{
   public class Person
    {
        public string Firstname { get; set; }
        public string Lastname  { get; set; }


        public void SayName()
        {
            Console.WriteLine("Full name :"+Firstname+ Lastname);
            Console.ReadLine();
        }
    }
}
