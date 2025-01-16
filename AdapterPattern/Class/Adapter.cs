using AdapterPattern.Interface;

namespace AdapterPattern.Class
{
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is `{this._adaptee.GetRequestSpecificRequest()}`";
        }
    }
}