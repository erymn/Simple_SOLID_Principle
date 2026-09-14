namespace Simple.SOLID.Core.LSP.Before;

public static class RectangleAreaCalculator
{
    /// <summary>
    /// Perfectly correct for a BadRectangle, but it produces the wrong answer
    /// for a BadSquare — i.e. the subtype cannot be substituted for its base.
    /// </summary>
    public static int ComputeArea(BadRectangle rectangle)
    {
        rectangle.Width = 4;
        rectangle.Height = 5;
        return rectangle.Width * rectangle.Height; // callers expect 20
    }
}