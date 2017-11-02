using System;

namespace classes
{
    // Everything in C# is made around classes.
    // classes are groups of related methods and variables
    // to use classes, you create a new instance of the class (like we did in
    // the functions solution) and you can then run use the methods and classes
    // from the class 
    class Program
    {
        static void Main(string[] args)
        {
            // this is us creating the new instance of the class Person.
            // now throughout our class Program, we can use Person's methods
            // and variables. By calling the class then the method
            // i.e.: 'person.describe()'
            Person person;
            string first;
            string last;
            int age;
            Console.WriteLine("Type in a first name");
            first = Console.ReadLine();
            Console.WriteLine("Type in a last name");
            last = Console.ReadLine();
            Console.WriteLine("Type in their age");
            age = int.Parse(Console.ReadLine());
            person = new Person(first, last, age);
            Console.WriteLine(person.Describe());
        }
    }

    // Normally classes will be created in their own files so it's easier to 
    // see the structure of the program. good practice is to have your variables
    // be private because if they are public they're accessable by everything,
    // which isn't fantastic. Instead you make them accessible through a method.

    class Person
    {
        private string fName;
        private string lName;
        private int age;

        public Person(string fname, string lname, int age)
        {
            this.fName = fname;
            this.lName = lname;
            this.age = age;
        }
        public string Describe()
        {
            return "This Person is " + fName + " " + lName + " and they are " +
                age + " years old.";
        }

    }
}
