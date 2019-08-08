namespace ShapeWorld.Domain.Models
{
    public class Cube : Shape
    {
        // a cube is made up of squares yet saying a cube inherits from square would suggest that they have the same number of edges
        // should a new shape be made that is for 3d shapes? that is, Shape3D is made up of Shape
        // or add a new constructor to shape to deal with 3d shapes
        // or just add the square to this cube
        public override double Surface() 
        {
            return 6 * BaseShape.Surface();
        }

        public new double Volume() {
            return 0;//BaseShape.Length();
        }

        public Cube() : base(12, new Square())
        {
            // BaseShape = new Square() square;
        }
    }
}