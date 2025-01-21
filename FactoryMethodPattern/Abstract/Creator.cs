using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern.Abstract
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Creator: the same creator`s code has just worked with " + product.Operation();
            return result;
        }
    }
}