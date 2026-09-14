namespace Simple.SOLID.Core.OCP;

/// <summary>
/// The extension point. New shipping options can be added by implementing
/// this interface — never by editing existing shipping classes.
/// </summary>
public interface IShippingCost
{
    string DisplayName { get; }

    decimal Calculate(decimal orderTotal);
}