namespace Simple.SOLID.Core.LSP.After;

public sealed class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius) => Radius = radius;

    public double Area => Math.PI * Radius * Radius;
}