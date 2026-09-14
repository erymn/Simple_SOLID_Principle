using Simple.SOLID.Core.DIP;

namespace Simple.SOLID.ConsoleApp.Demos;

public static class DipDemo
{
    public static void Run()
    {
        DemoUi.Header("D - Dependency Inversion Principle (DIP)");
        DemoUi.Line("\"High-level modules should not depend on low-level modules; both");
        DemoUi.Line("  should depend on abstractions.\"");

        DemoUi.Blank();
        DemoUi.Line("The high-level CheckoutService depends ONLY on IPaymentGateway.");
        DemoUi.Line("Each line below injects a different concrete gateway at the");
        DemoUi.Line("composition root (manual wiring - no DI container). The");
        DemoUi.Line("CheckoutService class itself never changes:");

        Checkout("Stripe",        new CheckoutService(new StripePaymentGateway()),   "ORD-1001", "Alice",   129.99m, "USD");
        Checkout("PayPal",        new CheckoutService(new PayPalPaymentGateway()),   "ORD-1002", "Bob",      49.50m, "EUR");

        DemoUi.Blank();
        DemoUi.Line("EXTENSION - a brand-new gateway class plugs in with zero changes");
        DemoUi.Line("to CheckoutService or to the existing gateways:");
        Checkout("Bank Transfer", new CheckoutService(new BankTransferGateway()),    "ORD-1003", "Charlie", 399.00m, "GBP");

        DemoUi.Blank();
    }

    private static void Checkout(string label, CheckoutService checkout, string orderId, string customer, decimal amount, string currency)
    {
        var result = checkout.Checkout(orderId, customer, amount, currency);
        DemoUi.Sub($"{label,-14} -> {result.GatewayName} #{result.TransactionId}  {result.Message}");
    }
}