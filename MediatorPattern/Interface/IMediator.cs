namespace MediatorPattern.Interface
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
