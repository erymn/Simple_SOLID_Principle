namespace Simple.SOLID.Core.LSP.After;

/// <summary>
/// ✅ Not a Rectangle subclass. Immutability removes the broken-setter trap,
/// so Squares behave exactly as any other IShape.
/// </summary>
public sealed class Square : IShape
{
    public double Side { get; }

    public Square(double side) => Side = side;

    public double Area => Side * Side;
}