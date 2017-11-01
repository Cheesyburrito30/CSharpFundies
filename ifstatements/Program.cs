using System;

namespace ifstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 11);
            int asdf = 0;
            while (asdf < 3)
            {
                int number;
                bool isNum;
                string input;

                Console.WriteLine("Please enter a number between 0 and 10");
                input = Console.ReadLine();
                // .TryParse will return a bool.
                // it takes two arguments, the one that it trys to parse and the
                // one that it outputs the true result to. 
                isNum = int.TryParse(input, out number);
                if (isNum)
                {
                    if (number > 10 || isNum & number < 0)
                        Console.WriteLine("Pick between 0 and 10!");
                    else if (number == randomNumber)
                        Console.WriteLine("You Picked the right number!");
                    else if (number > randomNumber)
                        Console.WriteLine("Your guess is bigger than the number!");
                    else if (number < randomNumber)
                        Console.WriteLine("Your guess is lower than the number!");
                }
                else
                    Console.WriteLine("That's not a number!");
                asdf++;
                Console.WriteLine("You have " + (3 - asdf) + " Tries left!");
            }

        }
    }
}
