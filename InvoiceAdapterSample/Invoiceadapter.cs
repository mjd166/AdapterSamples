namespace InvoiceAdapterSample
{
    public class Invoiceadapter : IOrderProcessor
    {
        private readonly InvoiceService service;

        public Invoiceadapter(InvoiceService service)
        {
            this.service = service;
        }

        public void ProcessOrder(string orderDetails)
        {
           service.GenerateInvoice(orderDetails);
        }
    }
}
