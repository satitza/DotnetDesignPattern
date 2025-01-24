using DecoratorPattern.Class;
using DecoratorPattern.Interface;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(Decorator pattern)");

            IBeverage coffee = new Coffee();
            Console.WriteLine(coffee.GetDescription());
            Console.WriteLine(coffee.GetCost());

            MilkDecorator milkDecorator = new MilkDecorator(coffee);
            Console.WriteLine(milkDecorator.GetDescription());
            Console.WriteLine(milkDecorator.GetCost());

            SugarDecorator sugarDecorator = new SugarDecorator(coffee);
            Console.WriteLine(sugarDecorator.GetDescription());
            Console.WriteLine(sugarDecorator.GetCost());
        }
    }
}