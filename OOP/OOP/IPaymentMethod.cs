using System;
namespace OOP
{
    interface IPaymentMethod
    {
        void ProcessPayment();
    }
    class D26CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }
    class D26EWalletPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing e-wallet payment...");
        }
    }
    class D26CashPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing cash payment...");
        }
    }
    class PaymentProcess
    {
        private IPaymentMethod _paymentProcess;
        public PaymentProcess(IPaymentMethod paymentProcess)
        {
            _paymentProcess = paymentProcess;
        }

        public void ExecutePayment()
        {
            Console.WriteLine("Executing payment process...");
            _paymentProcess.ProcessPayment();
        }

    }
}