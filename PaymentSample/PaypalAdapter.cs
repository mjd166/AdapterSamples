namespace PaymentSample
{
    /// <summary>
    /// adapter for paypal.
    /// </summary>
    public class PaypalAdapter : IPaymentProcessor
    {
        private readonly PayPalPaymentService service;

        public PaypalAdapter(PayPalPaymentService service)
        {
            this.service = service;
        }

        public void ProcessPayment(string paymentData)
        {
            service.SendPayment(paymentData);
        }
    }

}
