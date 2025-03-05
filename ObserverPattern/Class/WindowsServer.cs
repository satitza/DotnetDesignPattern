using ObServerPattern.Interface;

namespace ObServerPattern.Class
{
    public class WindowsServer : ISubscriber
    {
        public void Update(string dataMessage)
        {
            Console.WriteLine(string.Format("Windows server get data from data center : {0}", dataMessage));
        }
    }
}
