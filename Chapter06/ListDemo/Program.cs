using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> names = new List<string>();
        names.Add("Joe");
        names.Insert(0, "Car");
        names.Add("Jill");
        names[0] = "Building";
        names.RemoveAt(0);
        Console.WriteLine($"First name: {names[0]}");

        IList<Company> companies = new List<Company>
        {
            new Company { Name = "Syncfusion" },
            new Company { Name = "Microsoft" },
            new Company { Name = "Acme" }
        };

        foreach (Company cmp in companies)
            Console.WriteLine(cmp.Name);

        Console.ReadKey();
    }
}