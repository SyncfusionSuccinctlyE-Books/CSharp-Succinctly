using System;

class Program
{
    public static string Today => DateTime.Now.ToShortDateString();

    public static void Log(string message) => Console.WriteLine(message);

    public static void Main()
    {
        Log($"{Today} is a good day.");

        Console.ReadKey();
    }
}
