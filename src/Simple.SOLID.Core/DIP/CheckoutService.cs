namespace Simple.SOLID.Core.DIP;

/// <summary>
/// ✅ HIGH-LEVEL MODULE that depends only on the IPaymentGateway abstraction,
/// never on a concrete bank provider. Which gateway runs is decided at the
/// composition root (by the caller) — that is dependency inversion applied
/// with plain constructor injection, no container required.
/// </summary>
public sealed class CheckoutService
{
    private readonly IPaymentGateway _paymentGateway;

    public CheckoutService(IPaymentGateway paymentGateway)
        => _paymentGateway = paymentGateway;

    public PaymentResult Checkout(string orderId, string customerName, decimal amount, string currency)
    {
        var request = new PaymentRequest(orderId, customerName, amount, currency);
        return _paymentGateway.Charge(request);
    }
}