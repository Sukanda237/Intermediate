using System;

namespace Overridings
{

    public class Circle : Shape
    {
        public Circle()
        {
        }

        public override void Draw()
        {
            //base.Draw();
        Console.WriteLine("Draw A Circle");

        } 
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Draw A Rectangle");

        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Draw A Triangle");

        }
    }

    public class Shape
    {
        //public virtual void Draw()
        //{

        //}

        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }


        public virtual void Draw()
        {

        }
    }
}
