namespace Simple.SOLID.Core.SRP.Before;

/// <summary>
/// ❌ VIOLATION of the Single Responsibility Principle.
/// This single class deals with validation, pricing, persistence and
/// notifications — four completely different *reasons to change*.
/// </summary>
public sealed class BadOrderProcessor
{
    private readonly List<Order> _orders = new();

    public IReadOnlyList<Order> StoredOrders => _orders;

    public void Process(Order order)
    {
        ArgumentNullException.ThrowIfNull(order);

        // 1) Validation concern
        if (order.Items.Count == 0)
            throw new InvalidOperationException("Cannot process an empty order.");

        foreach (var item in order.Items)
        {
            if (item.Quantity <= 0 || item.UnitPrice < 0)
                throw new InvalidOperationException($"Invalid item: {item.ProductName}");
        }

        // 2) Pricing concern
        decimal total = 0m;
        foreach (var item in order.Items)
            total += item.Subtotal;

        order.ApplyTotal(total);

        // 3) Persistence concern (in-memory stand-in for a database)
        _orders.Add(order);

        // 4) Notification concern
        Console.WriteLine($"[E-Mail] Order {order.Id} totalling ${order.Total:F2} confirmed for {order.CustomerName}.");
    }
}