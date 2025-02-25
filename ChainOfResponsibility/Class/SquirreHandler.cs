using ChainOfResponsibility.Abstract;

namespace ChainOfResponsibility.Class
{
    public class SquirreHandler : AbstractHandler
    {
        public override object? Handle(object request)
        {
            if ((request as string) == "Nut")
            {
                return $"Squirre: I`ll eat the {request.ToString()}\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}