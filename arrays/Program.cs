using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // to create arrays, you need to type the type followed by []
            // 'int[]' Then after that you can create the array by typing
            // 'new int[]' You can put a number inside the brackets and that'll 
            // decide how long the array can be.

            int[] numbers = new int[5] { 1, 5, 8, 4, 10 };

            Console.WriteLine("Printing the array, without sorting");
            Array.ForEach(numbers, i => Console.WriteLine(i));

            // you can declare arrays even easier though, with int[] name = {..}
            // this might not be as easy to read later on though.

            Console.WriteLine("Sorting the array and then printing it");
            Array.Sort(numbers);

            Array.ForEach(numbers, (int obj) => Console.WriteLine(obj));

            // Arrays in C# can be multidimensional. that's a bit much for right
            // now though so expect that to be covered in a later commit.

        }
    }
}
