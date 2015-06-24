using System;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        decimal[] prices = { 1m, 2m, 3m };

        Type calcType = typeof(FinancialCalculator);
        MethodInfo sumMethod = calcType.GetMethod("Sum");
        FinancialCalculator calc = (FinancialCalculator)Activator.CreateInstance(calcType);
        decimal sum = (decimal)sumMethod.Invoke(calc, new object[] { prices });

        Console.WriteLine($"Sum: {sum}\nPress any key to continue.");
        Console.ReadKey();
    }
}
