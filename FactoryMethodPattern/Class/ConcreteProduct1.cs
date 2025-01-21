using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.Class
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}