namespace VisitorPattern.Class
{
    using Interface;
    
    public class Rectangle : IElement
    {
        public double _width { get; set; }
        
        public double _hight { get; set; }

        public Rectangle(double width, double hight)
        {
            this._width = width;
            this._hight = hight;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

