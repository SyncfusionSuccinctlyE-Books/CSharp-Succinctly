using System;

class Program
{
    static void Main()
    {
        var calc1 = new ScientificCalculator();

        var calc2 = new ScientificCalculator(0, "x")
        {
            EndAngle = 360
        };

        ScientificCalculator calc3 = null;
        try
        {
            calc3 = new ScientificCalculator();
            // do stuff
        }
        finally
        {
            if (calc3 != null)
                calc3.Dispose();
        }

        using (var calc4 = new ScientificCalculator())
        {
            // do stuff
        }

        Console.ReadKey();
    }
}
