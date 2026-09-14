namespace Simple.SOLID.Core.ISP.After;

/// <summary>✅ Implements exactly the two contracts that apply to humans.</summary>
public sealed class HumanEmployee : IWorkable, IFeedable
{
    public void Work() => Console.WriteLine("    Human : drafting a report...");
    public void Eat() => Console.WriteLine("    Human : having lunch...");
}