using System;

public class Program
{
    public static void Main()
    {
        decimal[] prices = { 1m, 2m, 3m };
        //Type calcType = typeof(FinancialCalculator);

        //decimal sum = GetSum(calcType, prices);
        decimal sum = GetSum<FinancialCalculator, decimal>(prices);

        Console.WriteLine($"Sum: {sum}\nPress any key to continue.");
        Console.ReadKey();
    }

    public static decimal GetSum(Type calcType, decimal[] prices)
    {
        dynamic calc = Activator.CreateInstance(calcType);
        dynamic sum = calc.Sum(prices);
        return sum;
    }

    public static TValue GetSum<TCalc, TValue>(TValue[] prices)
    where TCalc : new()
    {
        dynamic calc = new TCalc();
        TValue sum = calc.Sum(prices);
        return sum;
    }
}
