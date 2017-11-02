using System;
using System.Collections;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 6);
            Console.WriteLine("While loop: ");
            Console.WriteLine("This won't always print anything, it depends " +
                              "on if the parameter is true or not");
            while (number < 5)
            {
                Console.WriteLine(number);
                number++;
            }
            number = rnd.Next(0, 6);

            Console.WriteLine("Do While loop: ");
            Console.WriteLine("This will always at least write the number " +
                              "one time. then repeat depending on what the " +
                              "while parameters are.");
            do
            {
                Console.WriteLine(number);
                number++;
            } while (number < 5);
            number = rnd.Next(0, 6);

            ArrayList newArray = new ArrayList();
                newArray.Add("Mady Ward");
                newArray.Add("Simon Lee");
                newArray.Add("Nick Jackson");
                newArray.Add("Isaac Ludlow");
            Console.WriteLine("For Each loop: ");
            Console.WriteLine("This will iterate through the array until the" +
                              " array length is reached.");
            // with foreach, you have to declare the type that you want to get 
            // out of the array, (string name), if more than just a single type,
            // you can use the object type to pull them out as an object.
            foreach (string name in newArray)
                Console.WriteLine(name);

        }
    }
}
