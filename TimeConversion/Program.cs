using System;

public class Program
{
    public static void Main()
    {
        int totalSeconds = 125;
        string formatted = FormatTime(totalSeconds);
        Console.WriteLine(formatted);
    }

    public static string FormatTime(int totalSeconds)
    {
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        return $"{minutes}:{seconds:D2}";
    }
}
