namespace Simple.SOLID.Core.SRP.After;

/// <summary>✅ Reason to change: how/where orders are stored (memory, file, DB...).</summary>
public sealed class InMemoryOrderStore
{
    private readonly List<Order> _orders = new();

    public void Save(Order order) => _orders.Add(order);

    public IReadOnlyList<Order> All => _orders;
}