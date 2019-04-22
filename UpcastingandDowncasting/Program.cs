using System;

namespace UpcastingandDowncasting
{

    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            Shope shope = text;

            text.Width = 200;
            shope.Height = 100;

            Console.WriteLine(text.Width);
            Console.ReadKey();
        }
    }
}
