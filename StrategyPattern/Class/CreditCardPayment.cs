namespace StrategyPattern.Class
{
    using Interface;
    
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Pay {amount:C} using Credit Card.");
        }
    }
}
