namespace ShapeWorld.Domain.Models
{
    public class Rectangle : Shape 
    {
        public virtual double Length { get; set; }
        public virtual double Width { get; set; }

        public override double Perimeter()
        {
            return 2 * (Length + Width);
        }

        public override double Surface()
        {
            return Length * Width;
        }

        /** public new double Volume() // we doing a 'new' thing--ignore shape's volume 
        {
            return 1234;//Surface() * 10;
        }
        */

        public Rectangle() : base(4)
        {
        }
    }
}