namespace PaymentSample
{

    /// <summary>
    /// web controller  (Client Side)
    /// </summary>
    public class PaymentController
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public PaymentController(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void Checkout(string orderDetails)
        {
            Console.WriteLine("Starting checkout process...");

            _paymentProcessor.ProcessPayment(orderDetails);

            Console.WriteLine("Checkout completed successfully.");
        }
    }
}
