namespace ShapeWorld.Domain.Models
{
    public class Triangle : Shape
    {
        public double Height { get; private set; }
        public double Bottom { get; private set; }
        public double EdgeOne { get; private set; }
        public double EdgeTwo { get; private set; }
        public double EdgeThree { get; private set; }

        public override double Surface() 
        {
            return Bottom * Height / 2;
        }

        public override double Perimeter()
        {
            return EdgeOne + EdgeTwo + EdgeThree;
        }

        public Triangle(double edgeOne, double edgeTwo, double edgeThree) : base(3)
        {
            EdgeOne = edgeOne;
            EdgeTwo = edgeTwo;
            EdgeThree = edgeThree;
            
        }

        public Triangle() : base(3)
        {
        }
    }
}