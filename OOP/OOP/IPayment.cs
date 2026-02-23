using System;
namespace OOP
{
    interface IPayment
    {
        void ProcessPayment();
    }
    class D25CreditCardPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment.");
        }
    }
    class PayPalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment.");
        }
    }

    class CryptoPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing cryptocurrency payment.");
        }
    }
    class Order 
    {
        private IPayment _paymentMethod;
        public Order(IPayment paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }
        public void Checkout()
        {
            Console.WriteLine("Checking out order.");
            _paymentMethod.ProcessPayment();
        }
    }
}