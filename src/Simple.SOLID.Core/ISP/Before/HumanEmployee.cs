namespace Simple.SOLID.Core.ISP.Before;

public sealed class HumanEmployee : IWorker
{
    public void Work() => Console.WriteLine("    Human : drafting a report...");
    public void Eat() => Console.WriteLine("    Human : having lunch...");

    public void Recharge()
        => throw new NotSupportedException("Humans do not have batteries!");
}