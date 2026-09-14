namespace Simple.SOLID.Core.SRP.After;

/// <summary>✅ Reason to change: pricing / tax rules only.</summary>
public sealed class PriceCalculator
{
    public decimal CalculateTotal(Order order)
        => order.Items.Sum(item => item.Subtotal);
}