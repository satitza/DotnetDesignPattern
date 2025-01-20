using BuilderPattern.Class;

namespace BuilderPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dotnet design pattern(Builder pattern)");

            Computer computer = new Computer.Builder()
                .SetCpu("Ryzen 7 5700x3d")
                .SetRam(32)
                .SetPowerSupply(650)
                .SetSSD(1000)
                .Build();

            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());


            Car car = new Car.Builder()
                .WithEngine("RB26")
                .WithWheels(4)
                .WithColor("Black")
                .Build();
        }
    }
}