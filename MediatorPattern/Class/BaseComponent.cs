namespace MediatorPattern.Class
{
    using MediatorPattern.Interface;
    
    public class BaseComponent
    {
        public IMediator? _mediator;

        public BaseComponent(IMediator? mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}

