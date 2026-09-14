using Simple.SOLID.Core.LSP.After;
using CoreLspBefore = Simple.SOLID.Core.LSP.Before;

namespace Simple.SOLID.ConsoleApp.Demos;

public static class LspDemo
{
    public static void Run()
    {
        DemoUi.Header("L - Liskov Substitution Principle (LSP)");
        DemoUi.Line("\"Subtypes must be substitutable for their base types without");
        DemoUi.Line("  altering the correctness of the program.\"");

        DemoUi.Blank();
        DemoUi.Line("FIRST - the VIOLATION. BadSquare : BadRectangle redefines the");
        DemoUi.Line("setters, so code written for BadRectangle silently breaks when");
        DemoUi.Line("a BadSquare is passed in (the classic Rectangle/Square trap):");

        var baseRect = new CoreLspBefore.BadRectangle();
        var badSquare = new CoreLspBefore.BadSquare();

        DemoUi.Sub($"BadRectangle  area = {CoreLspBefore.RectangleAreaCalculator.ComputeArea(baseRect)}   (expected 20)");
        DemoUi.Sub($"BadSquare     area = {CoreLspBefore.RectangleAreaCalculator.ComputeArea(badSquare)}   (expected 20 -> got a wrong value)");

        DemoUi.Blank();
        DemoUi.Line("SECOND - the FIX. Immutable shapes all implement IShape and no");
        DemoUi.Line("longer inherit from each other. Consumers depend only on the");
        DemoUi.Line("abstraction, so ANY subtype behaves exactly as promised:");

        IShape[] shapes = { new Rectangle(4, 5), new Square(5), new Circle(3) };
        foreach (var shape in shapes)
            DemoUi.Sub($"  {ShapeAreaReporter.Describe(shape)}");

        DemoUi.Blank();
    }
}