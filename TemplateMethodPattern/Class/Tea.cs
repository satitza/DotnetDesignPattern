using TemplateMethodPattern.Abstract;

namespace TemplateMethodPattern.Class
{
    
    public class Tea : BeverageTemplate
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon...");
        }
    }
}
