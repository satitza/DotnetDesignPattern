using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.Class
{
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}