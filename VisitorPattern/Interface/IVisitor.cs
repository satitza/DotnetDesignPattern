namespace VisitorPattern.Interface
{
    using Class;
    
    public interface IVisitor
    {
        void Visit(Rectangle element);

        void Visit(Circle circle);
    }
}
