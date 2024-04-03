using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* there
             * are
             * a 
             * lot
             * of
             * variables
             */
            
            int peopleInHouse;
            peopleInHouse = 2;
            int b = 3;
            int c = peopleInHouse + b;
            string nameOne = "Stephen";
            string nameTwo = "Misha";
            string dogNameOne = "Boomer";
            string dogNameTwo = "Ace";
            string catNameOne = "Caroline";
            int dogAgeOne = 6;
            int dogAgeTwo = 8;
            int dogAgeThree = 10;
            double gotchaDayOne = 5.5;
            double gotchaDayTwo = 4.15;
            char atSymbol = '@';
            char sentenceEnd = '.';
            bool petLoveOne = true;
            
            bool petLoveTwo = false;

            Console.Write("Hello ");
            Console.Write(" World!");
            Console.ReadKey();
            Console.WriteLine(nameOne + " and " + nameTwo + " are married and live " + atSymbol + " 34 Some Place.");
            Console.ReadKey();
            Console.WriteLine("They have " + b + " pets.");
            Console.ReadKey();
            Console.WriteLine("Two dogs named " + dogNameOne + " and " + dogNameTwo + " and one cat named " + catNameOne + sentenceEnd);
            Console.ReadKey();
            Console.WriteLine("Together there are " + c + " members of their household.");
            Console.ReadKey();
            Console.Write(dogNameOne + " has lived with them for " + gotchaDayOne + " yearss\b!");
            Console.ReadKey();
            Console.Write("\n");
            Console.WriteLine(dogNameOne + " is " + dogAgeTwo + " to " + dogAgeThree + " years old.");
            Console.ReadKey();
            Console.WriteLine(dogNameTwo + " has lived with them for " + gotchaDayTwo + " years!");
            Console.ReadKey();
            Console.WriteLine(dogNameTwo + " is " + dogAgeOne + " to " + dogAgeTwo + " years old.");
            Console.ReadKey();
            Console.WriteLine("Do they love dogs?\t" + petLoveOne);
            Console.ReadKey();
            Console.WriteLine("Do they love cats?\t" + petLoveTwo);
            Console.WriteLine(nameTwo + " is the cat person");
            Console.Beep();


        }
    }
}
