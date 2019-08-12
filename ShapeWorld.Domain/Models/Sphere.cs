using ShapeWorld.Domain.Interfaces;

namespace ShapeWorld.Domain.Models
{
    public class Sphere : IThreeD
    {
        public double Height { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public double Volume() {
            return 0;//BaseShape.Length();
        }
    }
}