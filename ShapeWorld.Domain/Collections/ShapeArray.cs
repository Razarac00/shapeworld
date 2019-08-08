using System.Collections.Generic;
using ShapeWorld.Domain.Models;
using System.Linq;
using System;

namespace ShapeWorld.Domain.Collections
{
    public class ShapeArray
    {
        public void DimensionalArray() 
        {
            // 1D
            Shape[] shaped = new Shape[10];
            Shape[] shaped2 = new Shape[]{new Square()};

            // 2D
            Shape[,] shaped3 = new Shape[2,2];
            Shape[,] shaped4 = new Shape[,]
            {
                {new Square(), new Square()}, 
                {new Cube(), new Triangle()}
            };

            // 3D
            Shape[,,] shaped5 = new Shape[3,3,3];
            Shape[,,] shaped6 = new Shape[,,]
            {
                {
                    {new Rectangle(), new Square(), new Square()},
                    {new Rectangle(), new Square(), new Square()},
                    {new Rectangle(), new Square(), new Square()}
                },
                {
                    {new Rectangle(), new Square(), new Square()},
                    {new Rectangle(), new Square(), new Square()},
                    {new Rectangle(), new Square(), new Square()}
                },
                {
                    {new Rectangle(), new Square(), new Square()},
                    {new Rectangle(), new Square(), new Square()},
                    {new Rectangle(), new Square(), new Square()}
                }
            };

            // READ
            System.Console.WriteLine(shaped2[0]);
            System.Console.WriteLine(shaped4[1, 0]);
            System.Console.WriteLine(shaped6[1, 0, 2]);

            // WRITE
            shaped2[0] = new Circle();
            shaped4[1, 0] = new Triangle();
            shaped6[1, 0, 2] = new Rectangle();

            // JAGGED ARRAY -- an actual array of arrays, these other ones are just one array with a bunch of 'pointers'
            Shape[][] shaped7 = new Shape[10][];
            Shape[][] shaped8 = new Shape[][]
            {
                new Rectangle[10],
                new Circle[]{new Circle(), new Circle()}
            };

            System.Console.WriteLine(shaped8[1][1]);
        }

        public void MyList()
        {
            List<Shape> shaped = new List<Shape>();
            List<Shape> shaped2 = new List<Shape> {new Cube(), new Cube()};

            List<Shape[][,,]> shaped3 = new List<Shape[][,,]>();
            List<Shape[][,,]> shaped4 = new List<Shape[][,,]> {new Shape[5][,,]};

            // READ
            System.Console.WriteLine(shaped2[1]);
            System.Console.WriteLine(shaped2.Find(e => e.NumberOfEdges == 12));
            System.Console.WriteLine(shaped2.FirstOrDefault(e => e.NumberOfEdges == 4));

            // WRITE
            //shaped2[100] = new Rectangle(); // it's dynamic so it can jump, unlike arrays--but only if the default empty value is defined. So it works with int, but not objects
            shaped2.Add(new Triangle());
            shaped2.AddRange(shaped2);

            // REMOVE
            shaped2.Remove(new Cube()); // that's a new cube, nothing will be removed in this case
        }

        public void MyDictionary()
        {
            Dictionary<string, Shape> shaped = new Dictionary<string, Shape>();
            Dictionary<string, List<Shape>> shaped2 = new Dictionary<string, List<Shape>>
            {
                {"square", new List<Shape>()}
            };

            // READ
            System.Console.WriteLine(shaped2["square"]); //"I won't bore you with the 4th dimension" "This is how you read a dictionary"
            System.Console.WriteLine(shaped2.Select(d => d.Key == "square"));

            // WRITE
            shaped2["square"] = new List<Shape>(); // will add it or will update if it exists--try to avoid this as it may not be clear to others
            //shaped2.Add("square", new List<Shape>()); // only for adding--if square already exists, throw error
        }
    }
}