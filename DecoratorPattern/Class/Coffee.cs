using DecoratorPattern.Interface;

namespace DecoratorPattern.Class
{
    public class Coffee : IBeverage
    {
        public string GetDescription()
        {
            return "Coffee";
        }

        public double GetCost()
        {
            return 50;
        }
    }
}