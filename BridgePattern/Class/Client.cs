using BridgePattern.Abstract;

namespace BridgePattern.Class
{
    public class Client
    {
        public void ClientCode(Abstration abstration)
        {
            Console.WriteLine(abstration.Operation());
        }
    }
}