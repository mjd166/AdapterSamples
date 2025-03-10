namespace PaymentSample
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(string paymentData);
    }

}
