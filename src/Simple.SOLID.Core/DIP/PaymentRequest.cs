namespace Simple.SOLID.Core.DIP;

public sealed record PaymentRequest(string OrderId, string CustomerName, decimal Amount, string Currency);