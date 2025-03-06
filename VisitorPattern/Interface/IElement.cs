namespace VisitorPattern.Interface
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
