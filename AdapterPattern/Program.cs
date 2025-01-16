using AdapterPattern.Class;
using AdapterPattern.Interface;

namespace AdapterPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dotnet design pattern(Adapter pattern).");

            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adaptee client can call it`s method");

            Console.WriteLine(target.GetRequest());
        }
    }
}