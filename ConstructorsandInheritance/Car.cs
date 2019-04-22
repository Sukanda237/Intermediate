using System;

namespace ConstructorsandInheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car Is being initialized {0}", registrationNumber);
        }
    }
}
