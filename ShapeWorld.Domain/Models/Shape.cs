namespace ShapeWorld.Domain.Models
{
    public abstract class Shape
    {
        // fields - would be called variable at the method-scope
        // when made private, they become backing fields
        // private int numberOfEdges;

        // properties - a field masquerading as a method
        public int NumberOfEdges {get;} // could add private set; to allow shape to shapeshift lol


        // methods
        public virtual double Perimeter() // if specified in subclass, take that, else return this.
        {
            return 0;
        }

        public abstract double Surface();

        public double Volume()
        {
            return 0;
        }

        // controllers
        public Shape(int edges)
        {
            NumberOfEdges = edges;
        }

        public override string ToString() // string interpolation -- evaluate the string at runtime to give objects their stuff 
        {
            return $"{this.GetType().Name}: {NumberOfEdges} edges";
        }

    }
}