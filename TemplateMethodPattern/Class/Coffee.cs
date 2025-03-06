namespace TemplateMethodPattern.Class
{
    using Abstract;
    
    public class Coffee : BeverageTemplate
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk...");
        }
    }
}
