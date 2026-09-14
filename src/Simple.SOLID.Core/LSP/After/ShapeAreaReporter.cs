namespace Simple.SOLID.Core.LSP.After;

public static class ShapeAreaReporter
{
    /// <summary>
    /// Works for ANY IShape — Rectangle, Square, Circle, or anything added
    /// later. That is LSP in action: subtypes are fully substitutable.
    /// </summary>
    public static string Describe(IShape shape)
        => $"{shape.GetType().Name,-9}: area = {shape.Area:F2}";
}