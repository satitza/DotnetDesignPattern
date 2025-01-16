using FactoryPattern.Interface;

namespace FactoryPattern.Class
{
    public class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulProductA()
        {
            return "This is result from product A1.";
        }
    }
}
