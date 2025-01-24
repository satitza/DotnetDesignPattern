using ProxyPattern.Interface;

namespace ProxyPattern.Class
{
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}