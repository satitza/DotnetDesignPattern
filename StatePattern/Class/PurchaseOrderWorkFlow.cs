using StatePattern.Interface;

namespace StatePattern.Class
{
    public class PurchaseOrderWorkFlow : IWorkFlowContext
    {
        private IWorkFlowState _currentState;

        public bool _isCancelled = false;

        public bool _isApproved = false;

        public PurchaseOrderWorkFlow()
        {
            this._currentState = new CreatorWorkFlowState();
        }
        
        public void SetWorkFlowState(IWorkFlowState state)
        {
            this._currentState = state;
        }
        
        public void Submit() => this._currentState.Submit(this);

        public void Cancel() => this._currentState.Cancel(this);

        public void Approve() => this._currentState.Approve(this);

        public void Reject() => this._currentState.Reject(this);

 
    }
}

