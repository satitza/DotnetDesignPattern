namespace StatePattern.Interface
{
    public interface IWorkFlowState
    {
        void Submit(IWorkFlowContext context);

        void Cancel(IWorkFlowContext context);

        void Approve(IWorkFlowContext context);

        void Reject(IWorkFlowContext context);
    }
}
