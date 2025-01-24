using ProxyPattern.Class;
using ProxyPattern.Interface;

namespace ProxyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(proxy pattern)");

            Client client = new Client();
            Console.WriteLine("Client: Executing the client code with a real subject:");
            ISubject realSubject = new RealSubject();
            realSubject.Request();

            Console.WriteLine();
            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject: realSubject);
            client.ClientCode(proxy);
        }
    }
}