namespace TemplateMethodPattern.Abstract
{
    public abstract class BeverageTemplate
    {

        public void PrepareRecipe()
        {
            this.BoilWater();
            this.Brew();
            this.PourInCup();
            this.AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring in cup...");
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

    }
}
