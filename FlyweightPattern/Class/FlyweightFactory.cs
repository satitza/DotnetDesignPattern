namespace FlyweightPattern.Class
{
    using System.Linq;

    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var element in args)
            {
                this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(element), this.GetKey(element)));
            }
        }

        private string GetKey(Car key)
        {
            List<string> elements = new List<string>();

            elements.Add(key.Model);
            elements.Add(key.Color);
            elements.Add(key.Company);

            if (!string.IsNullOrEmpty(key.Owner) && !string.IsNullOrEmpty(key.Number))
            {
                elements.Add(key.Owner);
                elements.Add(key.Number);
            }

            return string.Join("_", elements);
        }

        public Flyweight? GetFlyweight(Car shareState)
        {
            string key = this.GetKey(shareState);

            if (this.flyweights.Count(w => w.Item2 == key) == 0)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(shareState), this.GetKey(shareState)));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }

            return this.flyweights.FirstOrDefault(w => w.Item2 == key)?.Item1;
        }

        public void listFlyweight()
        {
            var count = this.flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }
}