using System;

namespace Lkmqdoge.Monogame.Utils;

public static class Logger
{
    public static void Info(string text)    => Log(new (text, LogLevel.Info,    DateTime.Now));
    public static void Warning(string text) => Log(new (text, LogLevel.Warning, DateTime.Now));
    public static void Error(string text)   => Log(new (text, LogLevel.Error,   DateTime.Now));

    private static void Log(Entry entry)
    {
        var color = entry.Level switch 
        {
            LogLevel.Error   => ConsoleColor.DarkRed,
            LogLevel.Warning => ConsoleColor.DarkYellow,
            _                => Console.ForegroundColor
        };
        Console.ForegroundColor = color;
        Console.WriteLine(entry);
    }

    private enum LogLevel
    {
        Info,
        Warning,
        Error
    }

    private record Entry(string Text, LogLevel Level, DateTime Timestamp)
    {
        public override string ToString() 
            => $"[{Level}][{Timestamp}] {Text}";
    }
}
