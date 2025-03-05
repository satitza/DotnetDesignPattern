using ObServerPattern.Interface;

namespace ObServerPattern.Class
{
    public class DataCenter : IPublisher
    {
        private string _dataMessage = string.Empty;
        
        private readonly List<ISubscriber> _servers = new List<ISubscriber>();
        
        public void Attach(ISubscriber subscriber)
        {
            this._servers.Add(subscriber);
        }

        public void Detach(ISubscriber subscriber)
        {
            this._servers.Remove(subscriber);
        }

        public void SetDataMessage(string newMessage)
        {
            this._dataMessage = newMessage;
            this.Notify();
        }
        
        public void Notify()
        {
            foreach (var server in this._servers)
            {
                server.Update(this._dataMessage);
            }
        }
    }
}
