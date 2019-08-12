using System;
using ShapeWorld.Domain.Collections;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    internal class Program
    {
        // access extended/regular return name(params)
        private static void Main(string[] args)
        {
            PlayWithShape();
            // Console.WriteLine("Hello World!");
            // If no 'using System', then System.Console.WriteLine("Hello World!");
            PlayWithCollection();

            System.Console.WriteLine("\n /// WEEK 2 /// \n");
            PlayWithGeneric();
        }

        private static void PlayWithShape()
        {
            Shape someShape = new Rectangle(); // if cast fails, gives null
            Rectangle someSquare = new Square(); // if cast fails, will throw an error, so try to avoid this
            //someShape.NumberOfEdges = 10;
            //someShape.NumberOfEdges = 100;
            Square anotherSquare = new Square();
            Rectangle someRectangle = new Rectangle() as Square; //can cast objects into other objects--must be nullable so shape can't
            Cube someCube = new Cube();


            anotherSquare.Length = 10;
            anotherSquare.Width = 100;
            someCube.Length = 2;

            Console.WriteLine(someShape.NumberOfEdges);
            Console.WriteLine(anotherSquare.NumberOfEdges);
            Console.WriteLine(anotherSquare.Surface());
            Console.WriteLine(someShape.Volume()); //this will take Shape's volume over Rectangle's because it's 1st and 4most a Shape--variance.
            Console.WriteLine(someCube.Surface());
            
        }

        private static void PlayWithCollection()
        {
            ShapeArray sa = new ShapeArray();

            sa.DimensionalArray();
            sa.MyList();
            sa.MyDictionary();
        }

        private static void PlayWithGeneric() 
        {
            var gs = new GenericShape<Cube>();
            gs.SayHello(new Cube());
            gs.SayHello(new Triangle());

            var gs2 = new GenericShape<Cube>();
            gs2.SayHello(new Square()); // placeholder loses since Shape is already there. Can't overload with a clone

            var gs3 = new GenericShape<Sphere>();
            gs3.SayHello(new Square()); // rectangle is a closer parent than shape --> run rectangle method
            gs3.SayHello(new Triangle());
        }
        
    }
}
