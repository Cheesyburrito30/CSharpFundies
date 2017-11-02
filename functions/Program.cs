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

            // for functions that need an arbitrary amount of params, we can do
            // a few things. We can either pass them through as an array or list
            // or we can use the keyword params inside of the function parameter
            void typeNames(string[] names) 
            {
                // Array.ForEach (<yourName>, action)
                // the "{0}\t" is a tab
                Array.ForEach(names, i => Console.Write("{0}\t", i));
            };

            Console.WriteLine("Passing an array into a function sans params");
            typeNames(new string[] {"John", "Mady", "Vernon"});

            // using params in the parameter makes adding multiple of the same
            // type of params super easy, don't need to create a new string arr
            // or anything, just have to put in multiple parameters, seperated
            // by comma.
            // each function can have only one params parameter. Parameters 
            // declared with params are allowed to be empty when the function
            // is called. You can also call something like
            // void testFunction(int number, params string[] names)
            // and as long as the last parameters are all strings you can have 
            // the int as the first param, letting you pass more than one type.
            void paramsNames(params string[] names)
            {
                Array.ForEach(names, i => Console.Write("{0}\t", i));
            }
            Console.WriteLine();

            Console.WriteLine("Passing an array into a function with params");
            paramsNames("John", "Phil", "Michaels");
        }
    }
}
