using VisitorPattern.Class;
using VisitorPattern.Interface;

namespace VisitorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(Visitor pattern).");

            List<IElement> allShape = new List<IElement>()
            {
                new Rectangle(5, 10),
                new Circle(7)
            };

            IVisitor shapeVisitor = new AreaCalculatorVisitor();
            IVisitor shapePrinter = new ShapePrinterVisitor();

            foreach (var shape in allShape)
            {
                shape.Accept(shapeVisitor);
            }
            
            foreach (var shape in allShape)
            {
                shape.Accept(shapePrinter);
            }

        }
    }
}

