using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "\"Giraffe Academy\"";

            Console.WriteLine(phrase.IndexOf("G"));
            Console.WriteLine(phrase.Substring(3));

            Console.ReadLine();
        }
    }
}
