using ProxyPattern.Interface;

namespace ProxyPattern.Class
{
    public class Proxy : ISubject
    {
        private ISubject _realSubject;

        public Proxy(ISubject realSubject)
        {
            this._realSubject = realSubject;
        }


        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realSubject.Request();
                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}