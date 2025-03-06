using StrategyPattern.Interface;

namespace StrategyPattern.Class
{
    public class PaymentProcess
    {
        private IPaymentStrategy? _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy? paymentStrategy)
        {
            this._paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            if (this._paymentStrategy == null)
            {
                Console.WriteLine("No payment method not selected.");
                return;
            }
            
            this._paymentStrategy.Pay(amount);
            
        }
    }
}
