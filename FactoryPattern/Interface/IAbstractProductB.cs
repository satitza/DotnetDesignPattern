namespace FactoryPattern.Interface
{
    public interface IAbstractProductB
    {
        string UsefulProductB();

        string AnotherUsefulProductB(IAbstractProductA collaborator);
    }
}
