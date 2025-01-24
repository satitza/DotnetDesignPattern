using Newtonsoft.Json;

namespace FlyweightPattern.Class
{
    public class Flyweight
    {
        private Car _shareState;

        public Flyweight(Car car)
        {
            this._shareState = car;
        }


        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(this._shareState);
            string u = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: Display shared {s} and unique {u} state.");
        }
    }
}