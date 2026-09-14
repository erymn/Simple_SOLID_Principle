namespace Simple.SOLID.Core.SRP.After;

/// <summary>
/// ✅ Orchestrates the workflow and nothing else. It delegates each concern
/// to a dedicated collaborator, so it has a single reason to change
/// (the process flow), while every collaborator has its own single reason.
/// </summary>
public sealed class OrderProcessor
{
    private readonly OrderValidator _validator;
    private readonly PriceCalculator _calculator;
    private readonly InMemoryOrderStore _store;
    private readonly OrderEmailNotifier _notifier;

    public OrderProcessor(
        OrderValidator validator,
        PriceCalculator calculator,
        InMemoryOrderStore store,
        OrderEmailNotifier notifier)
    {
        _validator = validator;
        _calculator = calculator;
        _store = store;
        _notifier = notifier;
    }

    public void Process(Order order)
    {
        _validator.Validate(order);
        order.ApplyTotal(_calculator.CalculateTotal(order));
        _store.Save(order);
        _notifier.SendConfirmation(order);
    }
}