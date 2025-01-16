using FactoryPattern.Interface;

namespace FactoryPattern.Class
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulProductB()
        {
            return "The result of the product B1.";
        }

        public string AnotherUsefulProductB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulProductA();
            return $"The result of B1 collaborator with the ({result})";
        }
    }
}