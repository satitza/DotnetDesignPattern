using ObServerPattern.Class;

namespace ObServerPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(Observer pattern).");

            var dataCenter = new DataCenter();
            var windowsServer = new WindowsServer();
            var linuxServer = new LinuxServer();
            
            dataCenter.Attach(windowsServer);
            dataCenter.Attach(linuxServer);
            
            dataCenter.SetDataMessage("This first message.");
            
            dataCenter.Detach(linuxServer);
            
            dataCenter.SetDataMessage("Message after detach linux server.");
            
        }
    }
}

