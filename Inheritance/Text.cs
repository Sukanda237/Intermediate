using System;

namespace Inheritance
{
    public class Text : PresentationObject
    {
        public int FrontSize { get; set; }
        public int FrontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link  to {0} ", url);
        }
    }
}
