using System;

namespace MethodsExercise
{
   public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to my Methods Exercise Program");
            Methods mani = new Methods();

            int userinput = Convert.ToInt32(Console.ReadLine());

            Mathoperations();
            MathmethodTwo();
            MathoperationThree();
        }
    }
}
