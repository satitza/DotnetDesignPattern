using StatePattern.Interface;

namespace StatePattern.Class
{
    
    public class ApprovedWorkFlowState : IWorkFlowState
    {
        public void Submit(IWorkFlowContext context)
        {
            throw new Exception("Cannot submit document state is approved.");
        }

        public void Cancel(IWorkFlowContext context)
        {
            throw new Exception("Cannot cancel document state is approved.");
        }

        public void Approve(IWorkFlowContext context)
        {
            throw new Exception("Cannot approve document state is approved.");
        }

        public void Reject(IWorkFlowContext context)
        {
            throw new Exception("Cannot reject document state is approved.");
        }
    }
}
