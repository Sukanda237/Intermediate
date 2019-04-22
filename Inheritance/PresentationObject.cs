using System;

namespace Inheritance
{
    public class PresentationObject
    {
        public int Width { set; get; }
        public int Height { set; get; }

        public void copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
        }

    }
}
