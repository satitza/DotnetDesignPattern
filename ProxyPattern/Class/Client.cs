using ProxyPattern.Interface;

namespace ProxyPattern.Class
{
    public class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}