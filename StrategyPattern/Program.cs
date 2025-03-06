using StrategyPattern.Class;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(Strategy pattern).");

            PaymentProcess paymentProcess = new PaymentProcess();
            
            paymentProcess.SetPaymentStrategy(new CreditCardPayment());
            paymentProcess.ProcessPayment(500.55m);
            
            paymentProcess.SetPaymentStrategy(new BankTransferPayment());
            paymentProcess.ProcessPayment(200.25m);
            
        }
    }
}

