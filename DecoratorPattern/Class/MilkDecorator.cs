using DecoratorPattern.Abstract;
using DecoratorPattern.Interface;

namespace DecoratorPattern.Class
{
    public class MilkDecorator : BeverageDecorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Mile";
        }

        public override double GetCost()
        {
            return base.GetCost() + 10;
        }
    }
}