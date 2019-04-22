using System;

namespace InterfacesAndTestability
{


    class Program
    {
        static void Main(string[] args)
        {
            var OrderProcessor = new OrderProcessor();
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            OrderProcessor.Process(order);
            Console.ReadKey();
        }
    }
}
