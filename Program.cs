using System;

namespace varPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();

            MyMethod("It is a great day!");

            var message = MyMessage(userName, userAge);
            Console.WriteLine(message);



            Console.WriteLine("What is your characters name?");
            string myName = Console.ReadLine();
            
            
            float damage = 59.7f;
            decimal charisma = 10.59m;
            double dexterity = 75.2;
            bool male = true;
            int age = 25;
            decimal height = 6.1m;
            char favLetter = 'B';
            
            //random comment

            Console.WriteLine("Character Build");
            Console.WriteLine($"Character Name: {myName}");
            Console.WriteLine($"Character Stats: Damage:{damage}, Charisma:{charisma}, Dexterity: {dexterity} ");
            Console.WriteLine($"Male: {male}, Age: {age}, Height: {height}");
            Console.WriteLine($"His favorate letter in the alphabet is {favLetter}.");
            Console.WriteLine("The point of this is to be the winner!");
            Console.WriteLine("What is the issue I have?");

            Console.WriteLine("What is your partners name?");
            string yourName = Console.ReadLine();
            

            float damage2 = 45.7f;
            decimal charisma2 = 150.59m;
            double dexterity2 = 30.2;
            bool female = true;
            int age2 = 24;
            decimal height2 = 5.8m;
            char favLetter2 = 'H';

            Console.WriteLine("Character Build");
            Console.WriteLine($"Character Name: {yourName}");
            Console.WriteLine($"Character Stats: Damage:{damage2}, Charisma:{charisma2}, Dexterity: {dexterity2} ");
            Console.WriteLine($"Female: {female}, Age: {age2}, Height: {height2}");
            Console.WriteLine($"His favorate letter in the alphabet is {favLetter2}.");
            Console.WriteLine("The point of this is to be the winner!");
            Console.WriteLine("How can I help?");

            Console.WriteLine("This is a sorry of two adventurers. " +
                "What decisions will we have!");

            ulong enemySolders = 3254665465435;

            Console.WriteLine($"They will have to face {enemySolders} monsters!");

        }
        public static void MyMethod(string text)
        {
            Console.WriteLine(text);
        }
        public static string MyMessage(string name, string age)
        {
            return $"Hello {name}, how does it feel to be {age}?";
        }
    }
}