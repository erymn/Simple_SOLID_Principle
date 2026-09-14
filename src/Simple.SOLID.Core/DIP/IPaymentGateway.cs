namespace Simple.SOLID.Core.DIP;

/// <summary>Abstraction the high-level module depends on.</summary>
public interface IPaymentGateway
{
    string GatewayName { get; }

    PaymentResult Charge(PaymentRequest request);
}