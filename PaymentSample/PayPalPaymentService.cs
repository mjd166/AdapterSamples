namespace PaymentSample
{
    public class PayPalPaymentService
    {
        public void SendPayment(string paymentInfo)
        {
            Console.WriteLine($"PayPal payment sent: {paymentInfo}");
        }
    }

}
