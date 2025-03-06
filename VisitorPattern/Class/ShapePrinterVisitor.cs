namespace VisitorPattern.Class
{
    using Interface;
    
    public class ShapePrinterVisitor : IVisitor
    {
        public void Visit(Rectangle element)
        {
            Console.WriteLine($"Rectangle : [Width={element._width}], [Hight={element._hight}]");
        }

        public void Visit(Circle circle)
        {
            Console.WriteLine($"Circle : [Radius={circle._radius}]");
        }
    }
}
