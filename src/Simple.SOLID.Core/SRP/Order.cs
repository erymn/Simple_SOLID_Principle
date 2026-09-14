namespace Simple.SOLID.Core.SRP;

/// <summary>Pure data: a single line of an order.</summary>
public sealed record OrderItem(string ProductName, int Quantity, decimal UnitPrice)
{
    public decimal Subtotal => Quantity * UnitPrice;
}

/// <summary>Pure data: an order. It only knows how to manage its own state.</summary>
public sealed class Order
{
    private readonly List<OrderItem> _items = new();

    public string Id { get; } = Guid.NewGuid().ToString("N");
    public string CustomerName { get; init; } = string.Empty;
    public string CustomerEmail { get; init; } = string.Empty;
    public decimal Total { get; private set; }

    public IReadOnlyList<OrderItem> Items => _items;

    public void AddItem(OrderItem item) => _items.Add(item);
    public void ApplyTotal(decimal total) => Total = total;
}