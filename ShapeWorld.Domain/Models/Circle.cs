using System;

namespace ShapeWorld.Domain.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Surface() 
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public Circle() : base(1)
        {

        }
    }
}