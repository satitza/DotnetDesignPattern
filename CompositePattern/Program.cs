using CompositePattern.Abstract;
using CompositePattern.Class;

namespace CompositePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(composite pattern)");

            Client client = new Client();

            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component");
            client.ClientCode(leaf);

            Component tree = new Composite();

            Component branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());

            Component branch2 = new Composite();
            branch2.Add(new Leaf());

            tree.Add(branch1);
            tree.Add(branch2);

            Console.WriteLine("Client: Now I`ve get a composite tree:");
            client.ClientCode(tree);

            Console.WriteLine("Client: I don`t need to check the component classes even when managing the tree\n");
            client.ClientCode2(tree, leaf);
        }
    }
}