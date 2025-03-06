namespace VisitorPattern.Class
{
    using Interface;
    
    public class Circle : IElement
    {
        public double _radius { get; set; }

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
