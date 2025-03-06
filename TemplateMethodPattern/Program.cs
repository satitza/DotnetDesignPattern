using TemplateMethodPattern.Class;

namespace TemplateMethodPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(Template method).");

            Tea tea = new Tea();
            tea.PrepareRecipe();

            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();

        }
    }
}

