using FactoryPattern.Interface;

namespace FactoryPattern.Class
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulProductB()
        {
            return "The result of product B2.";
        }

        public string AnotherUsefulProductB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulProductA();
            return $"The result of the B2 collaborator with the ${result}";
        }
    }
}