using CoreIspAfter = Simple.SOLID.Core.ISP.After;
using CoreIspBefore = Simple.SOLID.Core.ISP.Before;

namespace Simple.SOLID.ConsoleApp.Demos;

public static class IspDemo
{
    public static void Run()
    {
        DemoUi.Header("I - Interface Segregation Principle (ISP)");
        DemoUi.Line("\"Clients should not be forced to depend on methods they do not use.\"");

        DemoUi.Blank();
        DemoUi.Line("FIRST - the VIOLATION. One fat IWorker forces HumanEmployee to");
        DemoUi.Line("implement Recharge() and RobotEmployee to implement Eat(), even");
        DemoUi.Line("though those concepts don't apply. The runner needs try/catch:");

        CoreIspBefore.IWorker[] fatWorkers =
        {
            new CoreIspBefore.HumanEmployee(),
            new CoreIspBefore.RobotEmployee(),
        };
        CoreIspBefore.ProductionLineRunner.Run(fatWorkers);

        DemoUi.Line("(notice the NotSupportedException swallowing above - a code smell");
        DemoUi.Line(" made necessary by the fat interface)");

        DemoUi.Blank();
        DemoUi.Line("SECOND - the FIX. Segregated contracts: IWorkable, IFeedable,");
        DemoUi.Line("IChargeable. Each worker implements exactly what it supports and");
        DemoUi.Line("ProductionLine only needs IWorkable - no hacks:");

        CoreIspAfter.IWorkable[] leanWorkers =
        {
            new CoreIspAfter.HumanEmployee(),
            new CoreIspAfter.RobotEmployee(),
        };
        CoreIspAfter.ProductionLine.Run(leanWorkers);

        DemoUi.Blank();
    }
}