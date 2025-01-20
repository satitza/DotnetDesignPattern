using BuilderPattern.Interface;

namespace BuilderPattern.Class
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public void BuildPartA()
        {
            this._product.AddPart("PartA1");
        }

        public void BuildPartB()
        {
            this._product.AddPart("PartB1");
        }

        public void BuildPartC()
        {
            this._product.AddPart("PartC1");
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}