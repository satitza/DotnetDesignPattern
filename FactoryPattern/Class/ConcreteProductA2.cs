using FactoryPattern.Interface;

namespace FactoryPattern.Class
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulProductA()
        {
            return "This is result from product A2.";
        }
    }
}
