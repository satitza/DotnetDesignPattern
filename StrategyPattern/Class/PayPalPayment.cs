namespace StrategyPattern.Class
{
    using Interface;
    
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Pay {amount:C} using PayPal.");
        }
    }
}
