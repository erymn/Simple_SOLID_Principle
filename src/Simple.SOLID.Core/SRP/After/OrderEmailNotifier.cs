namespace Simple.SOLID.Core.SRP.After;

/// <summary>✅ Reason to change: e-mail template / provider only.</summary>
public sealed class OrderEmailNotifier
{
    public void SendConfirmation(Order order)
        => Console.WriteLine($"[E-Mail] Order {order.Id} totalling ${order.Total:F2} confirmed for {order.CustomerName} <{order.CustomerEmail}>.");
}