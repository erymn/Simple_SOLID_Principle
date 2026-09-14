namespace Simple.SOLID.Core.OCP;

public sealed class InternationalShipping : IShippingCost
{
    public string DisplayName => "International (7-14 days)";

    public decimal Calculate(decimal orderTotal)
        => 24.99m + orderTotal * 0.05m;
}