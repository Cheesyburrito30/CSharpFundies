using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mady";
            string lastName = "Ward";

            Console.WriteLine("Current name is: " + firstName + ' ' + lastName);
            Console.WriteLine("Please enter a new first name.");
            firstName = Console.ReadLine();
            Console.WriteLine("New Name: " + firstName + ' ' + lastName);
            int number1, number2;
            Console.WriteLine("Enter a number!");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you, now another!");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Now we'll add them! " + (number2 + number1));
            Console.WriteLine("We're going to do fizzbuzz! Press enter to do it");
            Console.ReadLine();

            // fizzbuzz!
            for (int i = 0; i < 100; i ++) 
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0) 
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 == 0) 
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
