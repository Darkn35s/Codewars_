using System;
using codewars;

public class Program {
    public static void Main()
    {
        
        Rasim a = new Rasim();
        var startTime = System.Diagnostics.Stopwatch.StartNew();
        a.hren(100000);
        startTime.Stop();
        var resultTime = startTime.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
        resultTime.Hours,
        resultTime.Minutes,
        resultTime.Seconds,
        resultTime.Milliseconds);
        Console.WriteLine(elapsedTime);
    }

}

