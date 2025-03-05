namespace StatePattern.Class
{
    using Interface; 
    
    public class ManagerWorkFlowState : IWorkFlowState
    {
        public void Submit(IWorkFlowContext context)
        {
            throw new Exception("Document manager state cannot submit.");
        }

        public void Cancel(IWorkFlowContext context)
        {
            throw new Exception("Document manager state cannot cancel.");
        }

        public void Approve(IWorkFlowContext context)
        {
            Console.WriteLine("Manager approve document success.");
            context.SetWorkFlowState(new ApprovedWorkFlowState());
        }

        public void Reject(IWorkFlowContext context)
        {
            Console.WriteLine("Manager reject document to accounting.");
            context.SetWorkFlowState(new AccountingWorkFlowState());
        }
    }
}
