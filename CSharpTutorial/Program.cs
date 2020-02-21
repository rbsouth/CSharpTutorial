using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge;
            characterAge = 35;

            Console.WriteLine("There once was a man named " + characterName + ".");
            Console.WriteLine("He was " + characterAge + ".");
            Console.WriteLine("He really likes being named " + characterName + ".");
            Console.WriteLine("But he doesn't like being " + characterAge + ".");

            Console.ReadLine();
        }
    }
}
