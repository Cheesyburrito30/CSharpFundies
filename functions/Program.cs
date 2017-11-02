using System;

namespace functions
{
    class Program
    {
        public int AddNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        static void Main(string[] args)
        {
            // prog makes a new instance of program, which is the only thing
            // thing that is allowed to call functions that are made inside of
            // the program class, and not in the main area of the code.
            // so to run it we make a new program instance and use that to call
            // AddNumbers.
            // We can do this without prog, if we set the function to a static
            // function. however apparently this might cause problems in the
            // future with more complex functions


            Program prog = new Program();
            Console.WriteLine("Adding 1 and 5");
            Console.WriteLine(prog.AddNumbers(1, 5));

            int multiplyNumbers(int number1, int number2)
            {
                int result = number1 * number2;
                return result;
            }

            Console.WriteLine("Multiplying 3 and 4");
            Console.WriteLine(multiplyNumbers(3,4));
            int number = 20;

            // with the ref in our parameter, we're passing a reference to the 
            // thing that we put in the function's parameters, which means that
            // without directly referencing it in the function body, we will 
            // change whatever we put in the parameters
            // we could use out instead of ref, they both do the same thing,
            // out just doesn't need to variable to be initialized when called.
            void addFive(ref int asdf)
            {
                asdf = asdf + 5;
            }
            // without the ref in the parameter, we aren't passing a reference
            // that means that we can't actually change whatever we put into 
            // the called function's parameters, it will only change in the 
            // function block
            void addSix(int asdf)
            {
                asdf = asdf + 5;
            }

            Console.WriteLine(number);
            Console.WriteLine("Adding 5 to int number with reference");
            addFive(ref number);
            Console.WriteLine(number);
            Console.WriteLine("Adding 5 to int number without reference");
            addSix(number);
            Console.WriteLine(number);
        }
    }
}
