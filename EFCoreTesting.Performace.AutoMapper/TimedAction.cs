using System.Diagnostics;

public class TimedAction : IDisposable
{
    private readonly Stopwatch _stopwatch;
    public TimedAction()
    {
        _stopwatch = Stopwatch.StartNew();
    }

    public void Dispose()
    {
        _stopwatch.Stop();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Queried 1.000.000 rows in {_stopwatch.ElapsedMilliseconds}ms");
        Console.ResetColor();
    }
}