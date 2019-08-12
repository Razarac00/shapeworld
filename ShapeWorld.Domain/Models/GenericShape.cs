using ShapeWorld.Domain.Interfaces;

namespace ShapeWorld.Domain.Models
{
    public class GenericShape<S> where S : IThreeD
    {
        public void SayHello(S shape)
        {
            System.Console.WriteLine($"3D boi: {shape}");
        }

        public void SayHello(Shape shape)
        {
            System.Console.WriteLine($"yo check it: {shape}");
        }
    }
}