using DecoratorPattern.Interface;

namespace DecoratorPattern.Abstract
{
    public abstract class BeverageDecorator : IBeverage
    {
        protected IBeverage _beverage;

        public BeverageDecorator(IBeverage beverage)
        {
            this._beverage = beverage;
        }

        public virtual string GetDescription()
        {
            return this._beverage.GetDescription();
        }

        public virtual double GetCost()
        {
            return this._beverage.GetCost();
        }
    }
}