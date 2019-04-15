using System;

namespace Properties
{

    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person();
            person.Birthdate = new DateTime(1995, 5, 6);
            Console.WriteLine(person.Age);

            Console.ReadKey();
        }
    }
}
