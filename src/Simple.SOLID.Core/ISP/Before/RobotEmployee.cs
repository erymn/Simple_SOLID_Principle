namespace Simple.SOLID.Core.ISP.Before;

public sealed class RobotEmployee : IWorker
{
    public void Work() => Console.WriteLine("    Robot : assembling products...");

    public void Eat()
        => throw new NotSupportedException("Robots do not eat!");

    public void Recharge() => Console.WriteLine("    Robot : recharging at the dock...");
}