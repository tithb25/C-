using System;

namespace Shapes
{
    class Shapes
    {
        protected Location c;
        public string Tostring()
        {
            return "Area:";
        }
        public double Area()
        {
            return 0.000;
        }
        public double Perimeter()
        {
            return 0.000;
        }
    }
    class Rectangle : Shapes
    {
        protected double side2;
        protected double side1;

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
        public double Area()
        {
            return Side1 * Side2;
        }
    }
    class Circle : Shapes
    {
        protected double radius;

        public double Radius { get => radius; set => radius = value; }
        public double Area()
        {
            return Radius * Radius * 3.14;
        }
    }
    class Location
    {
        private double x, y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
    }
    class TestShape
    {
        static void Main()
        {
            Rectangle myRectangle = new Rectangle();
            myRectangle.Side1 = 10;
            myRectangle.Side2 = 20;
            Console.WriteLine(myRectangle.Area());

            Circle myCircle = new Circle();
            myCircle.Radius = 5;
            Console.WriteLine(myCircle.Area());


        }
    }
}
