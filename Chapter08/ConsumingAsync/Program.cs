using System;
using System.IO;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Program.CreateFileAsync("test.txt").Wait();
    }

    public static async Task CreateFileAsync(string filename)
    {
        using (StreamWriter writer = File.CreateText(filename))
            await writer.WriteAsync("This is a test.");
    }

    public async Task<string> ReturnGreeting()
    {
        await Task.Delay(1000);
        return "Hello";
    }

    public async void SayGreeting()
    {
        await Task.Delay(1000);
        Console.WriteLine("Hello");
    }
}
