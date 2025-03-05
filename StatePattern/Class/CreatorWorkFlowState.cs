namespace StatePattern.Class
{
    using Interface;
    
    public class CreatorWorkFlowState : IWorkFlowState
    {
        public void Submit(IWorkFlowContext context)
        {
            
            Console.WriteLine("Creator submit document to accounting state");
            context.SetWorkFlowState(new AccountingWorkFlowState());
        }

        public void Cancel(IWorkFlowContext context)
        {
            Console.WriteLine("Creator canceled document");
            context.SetWorkFlowState(new CancelledWorkFlowState());
        }

        public void Approve(IWorkFlowContext context)
        {
            throw new Exception("Cannot approve document is state creator");
        }

        public void Reject(IWorkFlowContext context)
        {
            throw new Exception("Cannot reject document is state creator");
        }
    }
}
