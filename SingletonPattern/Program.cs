using SingletonPattern.Class;

namespace SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(singleton pattern)");

            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            if (singleton1.GetHashCode() == singleton2.GetHashCode())
            {
                Console.WriteLine(
                    $"Singleton works, both variables contain the {singleton1.GetHashCode()} same {singleton2.GetHashCode()} instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}