namespace PaymentSample
{
    public class StripePaymentService
    {
        public void CreateCharge(string chargeData)
        {
            Console.WriteLine($"Stripe charge created: {chargeData}");
        }
    }
}
