using FactoryMethodPattern.Abstract;
using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.Class
{
    public class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}