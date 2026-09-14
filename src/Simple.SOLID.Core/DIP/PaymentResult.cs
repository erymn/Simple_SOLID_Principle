namespace Simple.SOLID.Core.DIP;

public sealed record PaymentResult(bool Succeeded, string TransactionId, string GatewayName, string Message);