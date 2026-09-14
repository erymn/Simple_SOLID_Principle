namespace Simple.SOLID.Core.ISP.After;

public static class ProductionLine
{
    /// <summary>✅ Depends only on IWorkable — no try/catch hacks needed.</summary>
    public static void Run(IEnumerable<IWorkable> workers)
    {
        foreach (var worker in workers)
            worker.Work();
    }
}