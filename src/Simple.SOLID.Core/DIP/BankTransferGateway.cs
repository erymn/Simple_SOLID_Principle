namespace Simple.SOLID.Core.DIP;

/// <summary>
/// Added later WITHOUT touching CheckoutService or the existing gateways.
/// The high-level code stays stable because it only knows IPaymentGateway.
/// </summary>
public sealed class BankTransferGateway : IPaymentGateway
{
    public string GatewayName => "Bank Transfer";

    public PaymentResult Charge(PaymentRequest request)
    {
        Console.WriteLine($"        [BankTransfer] sending charge request for {request.Currency} {request.Amount:F2}...");

        return new PaymentResult(
            Succeeded: true,
            TransactionId: $"BNK-{Guid.NewGuid().ToString("N")[..8].ToUpperInvariant()}",
            GatewayName: GatewayName,
            Message: $"Charged {request.Currency} {request.Amount:F2} for {request.CustomerName}");
    }
}