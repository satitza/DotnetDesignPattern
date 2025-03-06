namespace VisitorPattern.Class
{
    using Interface;
    
    public class AreaCalculatorVisitor : IVisitor
    {
        public void Visit(Rectangle element)
        {
            var area = element._hight * element._width;
            Console.WriteLine($"Rectangle area : {area}");
        }

        public void Visit(Circle circle)
        {
            var area = Math.PI * Math.Pow(circle._radius, 2);
            Console.WriteLine($"Circle area : {area}");
        }
    }
}
