using System;

namespace varPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Harley";
            string lastName = "Rogers";
            float damage = 59.7f;
            decimal charisma = 100.59m;
            double dexterity = 75.2;
            bool male = true;
            int age = 25;
            decimal height = 6.1m;
            char favLetter = 'h';
            
            //random comment

            Console.WriteLine("Character Build");
            Console.WriteLine($"Character Name: {firstName} {lastName}");
            Console.WriteLine($"Character Stats: Damage:{damage}, Charisma:{charisma}, Dexterity: {dexterity} ");
            Console.WriteLine($"Male: {male}, Age: {age}, Height: {height}");
            Console.WriteLine($"His favorate letter in the alphabet is {favLetter}.");
            Console.WriteLine("The point of this is to be the winner!");
            Console.WriteLine("What is the issue I have?");

        }
    }
}
