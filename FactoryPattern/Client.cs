using FactoryPattern.Class;
using FactoryPattern.Interface;

namespace FactoryPattern
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("Client: testing client with the first factory type...");
            ClientMethod(new ConcreteFacroty1());

            Console.WriteLine();

            Console.WriteLine("Client: testing the same client with second factory type...");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulProductB());
            Console.WriteLine(productB.AnotherUsefulProductB(productA));
        }
    }
}