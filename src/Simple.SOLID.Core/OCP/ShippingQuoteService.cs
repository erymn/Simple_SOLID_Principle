namespace Simple.SOLID.Core.OCP;

/// <summary>
/// Quotes every registered shipping option. It knows the IShippingCost
/// abstraction only — it never looks at concrete implementations, so it
/// never needs to change when a new shipping type appears.
/// </summary>
public sealed class ShippingQuoteService
{
    private readonly IEnumerable<IShippingCost> _options;

    public ShippingQuoteService(IEnumerable<IShippingCost> options)
        => _options = options;

    public IReadOnlyList<ShippingQuote> QuoteAll(decimal orderTotal)
        => _options
            .Select(option => new ShippingQuote(option.DisplayName, option.Calculate(orderTotal)))
            .ToList();
}