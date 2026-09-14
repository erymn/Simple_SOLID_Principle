using Simple.SOLID.ConsoleApp.Demos;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("  ============================================================");
Console.WriteLine("        SOLID Principles - Pure C# Console Demo");
Console.WriteLine("    No database | No external libraries | No DI container");
Console.WriteLine("    No MediatR - just plain interfaces, classes and wiring");
Console.WriteLine("  ============================================================");

SrpDemo.Run();
OcpDemo.Run();
LspDemo.Run();
IspDemo.Run();
DipDemo.Run();

Console.WriteLine();
Console.WriteLine("  Done - all five SOLID principles have been demonstrated.");