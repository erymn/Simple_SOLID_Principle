namespace Simple.SOLID.Core.OCP;

public sealed class StandardShipping : IShippingCost
{
    public string DisplayName => "Standard (5-7 days)";

    public decimal Calculate(decimal orderTotal)
        => orderTotal >= 100m ? 0m : 9.99m; // free over $100
}