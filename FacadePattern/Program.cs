using FacadePattern.Class;

namespace FacadePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(Facade pattern)");

            SubSystem1 subSystem1 = new SubSystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Client.ClientCode(new Facade(subSystem1, subsystem2));
        }
    }
}