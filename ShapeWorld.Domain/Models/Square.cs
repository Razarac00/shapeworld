namespace ShapeWorld.Domain.Models
{
    public class Square : Rectangle // : is like java extends, but also means 'link this to super's version'
    {
        private double _edgeLength;
        public override double Length 
        { 
            get
            {
                return _edgeLength;
            } 
            set
            {
                _edgeLength = value;
            } 
        }
        public override double Width 
        { 
            get
            {
                return _edgeLength;
            } 
            set
            {
                _edgeLength = value;
            } 
        }
    }
}