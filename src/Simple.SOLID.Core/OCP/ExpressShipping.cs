namespace Simple.SOLID.Core.OCP;

public sealed class ExpressShipping : IShippingCost
{
    public string DisplayName => "Express (1-2 days)";

    public decimal Calculate(decimal orderTotal)
        => 14.99m + orderTotal * 0.02m;
}