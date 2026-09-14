namespace Simple.SOLID.Core.DIP;

/// <summary>Low-level detail. Another pluggable IPaymentGateway.</summary>
public sealed class PayPalPaymentGateway : IPaymentGateway
{
    public string GatewayName => "PayPal";

    public PaymentResult Charge(PaymentRequest request)
    {
        Console.WriteLine($"        [PayPal] sending charge request for {request.Currency} {request.Amount:F2}...");

        return new PaymentResult(
            Succeeded: true,
            TransactionId: $"PYL-{Guid.NewGuid().ToString("N")[..8].ToUpperInvariant()}",
            GatewayName: GatewayName,
            Message: $"Charged {request.Currency} {request.Amount:F2} for {request.CustomerName}");
    }
}