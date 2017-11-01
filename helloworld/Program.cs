using System;
// using System is kind of like importing it, it allows us to use System.Console
// without needing to write System in front of it ever single time that we
// call it

namespace helloworld

{
    class Program
    {
        // static means that the method is instantiable without calling the class
        // void means that the method will not return anything, could set it to 
        // int if we wanted it to be returning an interger or string
        static void Main(string[] args)
        // Main is just the name of the method, in this one it's the main method
        // of the entire app.
        // args is the name of the arguments we're putting into the method, in 
        // our method args is set to an array of strings
        {
            // C# is a strongly typed language, which means that you're required
            // to declare the types of data you want the variables to be when 
            // called on
            int myNumber = 1;
            // int is short for interger, which is a non-floating number
            string myName = "Vernon Perry";
            // string is a group of chars
            // strings are immutable inside of C#, which means they can't be
            // changed after they are created. Any time that they are changed is
            // not them being changed, but them returning a new value
            char myChar = 'c';
            // char is a single character. Strings are made up of these
            // chars can only be in single quotes, not double, vice-versa for
            // strings
            float myFloat = 7.1F;
            // float is an integer that can have decimals.
            // you must put 'f' or 'F' after the integer otherwise the computer 
            // will think that you're trying to add two things to the variable
            bool myBool = true;
            // bools are booleans. Can be set to true OR false, nothing else
            Console.WriteLine("Hello World!");
            Console.WriteLine(myName);
            Console.WriteLine(myNumber);
            Console.WriteLine(myChar);
            Console.WriteLine(myFloat);
            if (myBool)
            {
                Console.WriteLine("asdf");
            }
             // without this line, the console will just complete the application
             // without the user having done anything, and will look like nothing
             // happened.
            Console.ReadLine();
            // Listens for the user's input.
        }
    }
}
