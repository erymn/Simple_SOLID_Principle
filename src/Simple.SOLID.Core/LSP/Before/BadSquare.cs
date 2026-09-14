namespace Simple.SOLID.Core.LSP.Before;

/// <summary>
/// ❌ VIOLATION of the Liskov Substitution Principle.
/// BadSquare redefines the setters to keep both sides equal, which silently
/// breaks the contract that BadRectangle code relies on.
/// </summary>
public sealed class BadSquare : BadRectangle
{
    public override int Width
    {
        set { base.Width = value; base.Height = value; }
    }

    public override int Height
    {
        set { base.Width = value; base.Height = value; }
    }
}