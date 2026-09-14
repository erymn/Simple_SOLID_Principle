namespace Simple.SOLID.Core.DIP;

/// <summary>Low-level detail. Pluggable in through the IPaymentGateway abstraction.</summary>
public sealed class StripePaymentGateway : IPaymentGateway
{
    public string GatewayName => "Stripe";

    public PaymentResult Charge(PaymentRequest request)
    {
        // Console stands in for a real HTTP call to the Stripe API.
        Console.WriteLine($"        [Stripe] sending charge request for {request.Currency} {request.Amount:F2}...");

        return new PaymentResult(
            Succeeded: true,
            TransactionId: $"STR-{Guid.NewGuid().ToString("N")[..8].ToUpperInvariant()}",
            GatewayName: GatewayName,
            Message: $"Charged {request.Currency} {request.Amount:F2} for {request.CustomerName}");
    }
}