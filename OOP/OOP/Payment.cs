using System;
namespace OOP
{
    class Payment
    {
        public virtual void processPayment()
        {
            Console.WriteLine("Processing  generic payment...");
        }
        public virtual void showPaymentType()
        {
            Console.WriteLine("Showing generic payment type: ");
        }
    }

    class CreditCardPayment : Payment
    {
        public override void processPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
        public override void showPaymentType()
        {
            Console.WriteLine("Payment type: Credit Card");
        }
    }

    class CashPayment : Payment
    {
        public override void processPayment()
        {
            Console.WriteLine("Processing cash payment...");
        }
        public override void showPaymentType()
        {
            Console.WriteLine("Showing payment type: Cash");
        }
    }
    
}