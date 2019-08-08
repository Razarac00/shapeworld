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
        
    }
}
