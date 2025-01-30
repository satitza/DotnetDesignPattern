using ChainOfResponsibility.Class;

namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(Responsibility pattern)");

            var monkey = new MonkeyHandler();
            var squirrel = new SquirreHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();
            
            Console.WriteLine("Sub chain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);
        }
    }
}