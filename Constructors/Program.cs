using System;

namespace Constructors
{


    class Program
    {
        static void Main(string[] args)
        {

            var customer = new Customer();
            var customer2 = new Customer(1, "UUN");
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.Name);

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            Console.ReadKey();
        }
    }
}
