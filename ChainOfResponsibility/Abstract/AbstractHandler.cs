using ChainOfResponsibility.Interface;

namespace ChainOfResponsibility.Abstract
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler? _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return this._nextHandler;
        }

        public virtual object? Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}