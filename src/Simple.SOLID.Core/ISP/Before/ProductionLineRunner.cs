namespace Simple.SOLID.Core.ISP.Before;

public static class ProductionLineRunner
{
    /// <summary>
    /// The fat interface forces the call site to swallow exceptions from
    /// methods the workers were never meant to have. Pure code smell.
    /// </summary>
    public static void Run(IEnumerable<IWorker> workers)
    {
        foreach (var worker in workers)
        {
            worker.Work();

            try { worker.Eat(); }
            catch (NotSupportedException) { }

            try { worker.Recharge(); }
            catch (NotSupportedException) { }
        }
    }
}