namespace Simple.SOLID.Core.LSP.After;

/// <summary>
/// ✅ The abstraction that consumers depend on. Because every subtype honours
/// this contract, any subtype can be substituted without breaking behaviour.
/// </summary>
public interface IShape
{
    double Area { get; }
}