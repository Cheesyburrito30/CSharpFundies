using System;

namespace switchstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Dragon rears it's ugly head and tries to " +
                              "eat the Princess before you can save her!");
            Console.WriteLine("What are you going to do about it?!");
            string input = Console.ReadLine();
            switch(input.ToLower())
            {
                case "fight":
                    Console.WriteLine("You bravely fight the dragon!");
                    break;
                case "run away":
                    Console.WriteLine("Your cowardice has left the kingdom" +
                                      "in peril, and without a ruler");
                    break;
                case"pee my pants":
                    Console.WriteLine("You feel a wet warmth roll down your leg");
                    break;
                default:
                    Console.WriteLine("You do nothing, and get eaten.");
                    break;
                
            }
        }
    }
}
