namespace Simple.SOLID.Core.SRP.After;

/// <summary>✅ Reason to change: validation rules only.</summary>
public sealed class OrderValidator
{
    public void Validate(Order order)
    {
        ArgumentNullException.ThrowIfNull(order);

        if (order.Items.Count == 0)
            throw new InvalidOperationException("Cannot process an empty order.");

        foreach (var item in order.Items)
        {
            if (item.Quantity <= 0 || item.UnitPrice < 0)
                throw new InvalidOperationException($"Invalid item: {item.ProductName}");
        }
    }
}