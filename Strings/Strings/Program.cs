using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is all about Strings:");

            String name = "Anish";
            String quote = "The employer is saying, I am a \"Great\" Employee.\n Also tells me, I smell good\n \t\t I feel\t the same.";
            String exer = "One of the best moments ever is when my code runs without failing.";

            String conCate = ("This is concatenation" + name + "and" + quote + exer + "excellent");

            Console.WriteLine(conCate);
            Console.ReadLine();

            name = name.ToUpper();

            Console.WriteLine(name);
            Console.ReadLine();


            Console.WriteLine(name);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Anish\n");
            //Console.WriteLine(sb);
            sb.Append("Suryudu chandrudu ramudu bheemudu, krishnudu vishnuvu kalisadante veedu\n");
            //Console.WriteLine(sb);
            sb.Append("Dharma nibhaddudu, asrva samarhdudu, cheekati chelchadante veedu, janame nenu , nene janam antadu, rakhtam range raksha gunam antadu\n");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
