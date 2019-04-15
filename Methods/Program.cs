using System;

namespace Methods
{

    class Program
    {
        static void Main(string[] args)
        {


            int number;
            var result = int.TryParse("abc", out number);

            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("conversion failed");

            Console.ReadKey();
        }

        static void UseParams()
        {
            var Calculator = new Calculator();
            Console.WriteLine(Calculator.Add(1, 2));
            Console.WriteLine(Calculator.Add(1, 2, 3));
            Console.WriteLine(Calculator.Add(1, 2, 3, 4));
            Console.WriteLine(Calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoints()
        {
            var point = new Point(10, 20);
            try
            {
                point.move(null);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);


                point.move(100, 200);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexoected error  orccured");
            }
        }
    }
}
