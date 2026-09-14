using Simple.SOLID.Core.OCP;

namespace Simple.SOLID.ConsoleApp.Demos;

public static class OcpDemo
{
    private const decimal OrderTotal = 249.95m;

    public static void Run()
    {
        DemoUi.Header("O - Open/Closed Principle (OCP)");
        DemoUi.Line("\"Software entities should be open for extension, but closed for");
        DemoUi.Line("  modification.\"");

        DemoUi.Blank();
        DemoUi.Line("Shipping options are pluggable. ShippingQuoteService knows only");
        DemoUi.Line("the IShippingCost abstraction - it never sees a concrete class:");

        var options = new List<IShippingCost>
        {
            new StandardShipping(),
            new ExpressShipping(),
            new InternationalShipping(),
        };

        PrintQuotes(new ShippingQuoteService(options), OrderTotal);

        DemoUi.Blank();
        DemoUi.Line("EXTENSION - add a brand-new option by writing ONE new class.");
        DemoUi.Line("Existing classes (Standard/Express/International and");
        DemoUi.Line("ShippingQuoteService) are NOT modified - closed for modification:");
        options.Add(new PickupInStoreShipping());

        PrintQuotes(new ShippingQuoteService(options), OrderTotal);

        DemoUi.Blank();
    }

    private static void PrintQuotes(ShippingQuoteService service, decimal orderTotal)
    {
        DemoUi.Sub($"Quotes for order total = ${orderTotal:F2}:");
        foreach (var quote in service.QuoteAll(orderTotal))
            DemoUi.Sub($"  - {quote.Option,-34} => ${quote.Cost:F2}");
    }
}