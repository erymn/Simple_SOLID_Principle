using Simple.SOLID.Core.SRP;
using Simple.SOLID.Core.SRP.After;
using Simple.SOLID.Core.SRP.Before;

namespace Simple.SOLID.ConsoleApp.Demos;

public static class SrpDemo
{
    public static void Run()
    {
        DemoUi.Header("S - Single Responsibility Principle (SRP)");
        DemoUi.Line("\"A class should have one, and only one, reason to change.\"");

        DemoUi.Blank();
        DemoUi.Line("FIRST - the VIOLATION. BadOrderProcessor validates the order,");
        DemoUi.Line("prices it, persists it AND e-mails the customer. One god class,");
        DemoUi.Line("four reasons to change:");

        var badProcessor = new BadOrderProcessor();
        badProcessor.Process(BuildOrder("Alice"));

        DemoUi.Blank();
        DemoUi.Line("SECOND - the REFACTOR. Every concern moved to a dedicated class");
        DemoUi.Line("with a single reason to change. OrderProcessor merely orchestrates");
        DemoUi.Line("them (constructor injection, manually wired - no container):");

        var store = new InMemoryOrderStore();
        var processor = new OrderProcessor(
            new OrderValidator(),     // reason to change: validation rules
            new PriceCalculator(),    // reason to change: pricing rules
            store,                    // reason to change: persistence
            new OrderEmailNotifier()); // reason to change: notifications

        processor.Process(BuildOrder("Bob"));
        processor.Process(BuildOrder("Charlie"));

        DemoUi.Sub("Stored orders now visible through the store alone:");
        foreach (var order in store.All)
            DemoUi.Sub($"  - {order.Id[..6]}... {order.CustomerName,-8} total = ${order.Total:F2}");

        DemoUi.Blank();
    }

    private static Order BuildOrder(string customerName)
    {
        var order = new Order
        {
            CustomerName = customerName,
            CustomerEmail = $"{customerName.ToLowerInvariant()}@example.dev",
        };

        order.AddItem(new OrderItem("Mechanical Keyboard", 1, 89.99m));
        order.AddItem(new OrderItem("USB-C Cable", 2, 12.50m));

        return order;
    }
}