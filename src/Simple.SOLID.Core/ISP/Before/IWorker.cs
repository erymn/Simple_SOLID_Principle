namespace Simple.SOLID.Core.ISP.Before;

/// <summary>
/// ❌ VIOLATION of the Interface Segregation Principle.
/// One fat interface forces every worker to implement Eat() and Recharge()
/// even when those concepts do not apply to them.
/// </summary>
public interface IWorker
{
    void Work();
    void Eat();
    void Recharge();
}