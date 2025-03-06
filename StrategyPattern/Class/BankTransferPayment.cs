namespace StrategyPattern.Class
{
    using Interface;
    
    public class BankTransferPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"pay {amount:C} using Bank Transfer.");
        }
    }
}
