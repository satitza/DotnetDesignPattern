using ChainOfResponsibility.Abstract;

namespace ChainOfResponsibility.Class
{
    public class DogHandler : AbstractHandler
    {
        public override object? Handle(object request)
        {
            if ((request as string) == "MeatBall")
            {
                return $"Dog: I`ll eat the {request.ToString()}\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}