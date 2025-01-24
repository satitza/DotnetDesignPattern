namespace FacadePattern.Class
{
    public class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.WriteLine(facade.Operation());
        }
    }
}