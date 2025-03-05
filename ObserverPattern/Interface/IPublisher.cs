namespace ObServerPattern.Interface
{
    public interface IPublisher
    {
        void Attach(ISubscriber subscriber);

        void Detach(ISubscriber subscriber);
        
        void Notify();

    }
}
