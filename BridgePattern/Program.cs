using BridgePattern.Abstract;
using BridgePattern.Class;

namespace BridgePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(Bridge pattern)");

            Client client = new Client();

            Abstration abstration;
            abstration = new ExtendedAbstraction(new ConcreteImplementationA());
            client.ClientCode(abstration);

            Console.WriteLine();

            abstration = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstration);
        }
    }
}