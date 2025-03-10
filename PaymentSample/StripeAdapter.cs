namespace PaymentSample
{
    /// <summary>
    /// adapter for stripe 
    /// </summary>
    public class StripeAdapter : IPaymentProcessor
    {
        private readonly StripePaymentService service;

        public StripeAdapter(StripePaymentService service)
        {
            this.service = service;
        }

        public void ProcessPayment(string paymentData)
        {
           service.CreateCharge(paymentData);
        }
    }

}
