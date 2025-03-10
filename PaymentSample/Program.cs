//Web app simulate.

using PaymentSample;

var stripeService=new StripePaymentService();
var stripeprocessor= new StripeAdapter(stripeService);
var stripepaymentController= new PaymentController(stripeprocessor);
stripepaymentController.Checkout("Order #12345 - Amount: $100");


// Using PayPal
PayPalPaymentService payPalService = new PayPalPaymentService();
IPaymentProcessor payPalProcessor = new PaypalAdapter(payPalService);
PaymentController payPalController = new PaymentController(payPalProcessor);
payPalController.Checkout("Order #54321 - Amount: $200");
