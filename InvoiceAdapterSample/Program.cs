using InvoiceAdapterSample;

IOrderProcessor orderProcessor = new Invoiceadapter(new InvoiceService());

orderProcessor.ProcessOrder("Order #12308 - 1x laptop asus , 1x mosue");