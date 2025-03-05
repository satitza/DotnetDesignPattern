using ObServerPattern.Interface;

namespace ObServerPattern.Class
{
    public class LinuxServer : ISubscriber
    {
        public void Update(string dataMessage)
        {
            Console.WriteLine(string.Format("Linux server get data from data center : {0}", dataMessage));
        }
    }
}
