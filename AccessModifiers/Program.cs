﻿using System;

namespace AccessModifiers
{
    class Program
    {

        public class Person
        {
            private DateTime _birthdate;

            public void SetBirthdate(DateTime birthdate)
            {
                _birthdate = birthdate;
            }

            public DateTime GetBirthdate()
            {
                return _birthdate;
            }
        }

        static void Main(string[] args)
        {

            var person = new Person();
            person.SetBirthdate(new DateTime(1996, 4, 9));

            Console.WriteLine(person.GetBirthdate());

            Console.ReadKey();
        }
    }
}
