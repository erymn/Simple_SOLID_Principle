namespace Simple.SOLID.Core.LSP.Before;

/// <summary>A rectangle with freely settable sides.</summary>
public class BadRectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public virtual int Area => Width * Height;
}