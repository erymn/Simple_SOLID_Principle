namespace Simple.SOLID.Core.ISP.After;

/// <summary>✅ Implements exactly the two contracts that apply to robots.</summary>
public sealed class RobotEmployee : IWorkable, IChargeable
{
    public void Work() => Console.WriteLine("    Robot : assembling products...");
    public void Recharge() => Console.WriteLine("    Robot : recharging at the dock...");
}