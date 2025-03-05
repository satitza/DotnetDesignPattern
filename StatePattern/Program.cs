namespace StatePattern
{
    using Class;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(State pattern).");

            try
            {
                PurchaseOrderWorkFlow purchaseOrder1 = new PurchaseOrderWorkFlow();
            
                purchaseOrder1.Submit();
                purchaseOrder1.Approve();
                purchaseOrder1.Reject();
                purchaseOrder1.Reject();
                purchaseOrder1.Cancel();
                purchaseOrder1.Submit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine("--------------------------------------------------------------------------------");

            try
            {
                PurchaseOrderWorkFlow purchaseOrder2 = new PurchaseOrderWorkFlow();
                
                purchaseOrder2.Submit();
                purchaseOrder2.Approve();
                purchaseOrder2.Approve();
                purchaseOrder2.Reject();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

