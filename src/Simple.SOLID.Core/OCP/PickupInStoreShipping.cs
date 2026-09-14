namespace Simple.SOLID.Core.OCP;

/// <summary>
/// Added LATER as a brand-new class with ZERO changes to existing code —
/// that is exactly what "open for extension, closed for modification" means.
/// </summary>
public sealed class PickupInStoreShipping : IShippingCost
{
    public string DisplayName => "Pick-up in store (today)";

    public decimal Calculate(decimal orderTotal) => 0m;
}