using System;

namespace AbstractClassespage124
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Abstract classes program ki welcome");

            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            Console.ReadLine();

        }
    }
}
