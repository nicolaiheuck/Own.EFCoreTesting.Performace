using System.Diagnostics;

public class TimedAction : IDisposable
{
    private readonly Stopwatch _stopwatch;
    private readonly string _comment;

    public TimedAction(string comment)
    {
        _stopwatch = Stopwatch.StartNew();
        _comment = comment;
    }

    public void Dispose()
    {
        _stopwatch.Stop();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Queried 1.000.000 rows in {_stopwatch.ElapsedMilliseconds}ms (Query: \"{_comment}\")");
        Console.ResetColor();
    }
}