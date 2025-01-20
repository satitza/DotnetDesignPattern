namespace BuilderPattern.Class
{
    public class Car
    {
        public string Engine { get; }
        public int Wheels { get; }
        public string Color { get; }

        private Car(string engine, int wheels, string color)
        {
            Engine = engine;
            Wheels = wheels;
            Color = color;
        }


        public class Builder
        {
            private string _engine;
            private int _wheels;
            private string _color;

            public Builder WithEngine(string engine)
            {
                _engine = engine;
                return this;
            }

            public Builder WithWheels(int wheels)
            {
                _wheels = wheels;
                return this;
            }

            public Builder WithColor(string color)
            {
                _color = color;
                return this;
            }

            public Car Build()
            {
                return new Car(_engine, _wheels, _color);
            }
        }
    }
}