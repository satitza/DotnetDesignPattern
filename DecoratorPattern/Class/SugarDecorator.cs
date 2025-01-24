using DecoratorPattern.Abstract;
using DecoratorPattern.Interface;

namespace DecoratorPattern.Class
{
    public class SugarDecorator : BeverageDecorator
    {
        public SugarDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar";
        }

        public override double GetCost()
        {
            return base.GetCost() + 5;
        }
    }
}