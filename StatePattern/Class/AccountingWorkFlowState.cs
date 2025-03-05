namespace StatePattern.Class
{
    using Interface;
    
    public class AccountingWorkFlowState : IWorkFlowState
    {
        public void Submit(IWorkFlowContext context)
        {
            throw new Exception("Document accounting state cannot submit.");
        }

        public void Cancel(IWorkFlowContext context)
        {
            throw new Exception("Document accounting state cannot cancel.");
        }

        public void Approve(IWorkFlowContext context)
        {
            Console.WriteLine("Accounting has approve document to manager.");
            context.SetWorkFlowState(new ManagerWorkFlowState());
        }

        public void Reject(IWorkFlowContext context)
        {
            Console.WriteLine("Accounting has reject document to creator.");
            context.SetWorkFlowState(new CreatorWorkFlowState());
        }
    }
}
