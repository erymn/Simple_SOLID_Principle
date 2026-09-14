namespace Simple.SOLID.ConsoleApp;

/// <summary>Tiny UI helper that keeps the demo output consistent.</summary>
internal static class DemoUi
{
    public static void Header(string title)
    {
        Console.WriteLine();
        Console.WriteLine(new string('=', 78));
        Console.WriteLine("  " + title);
        Console.WriteLine(new string('=', 78));
    }

    public static void Line(string text) => Console.WriteLine("    " + text);
    public static void Sub(string text) => Console.WriteLine("        " + text);
    public static void Blank() => Console.WriteLine();
}