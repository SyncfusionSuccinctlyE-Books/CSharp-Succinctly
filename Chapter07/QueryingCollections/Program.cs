using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IEnumerable<Customer> customers =
            from cust in Company.Customers
            select cust;

        foreach (Customer cust in customers)
            Console.WriteLine(cust.Name);

        IEnumerable<string> customers2 =
            from cust2 in Company.Customers
            select cust2.Name;

        IEnumerable<CustomerViewModel> customerVMs =
            from custVM in Company.Customers
            select new CustomerViewModel
            {
                Name = custVM.Name
            };

        var customers3 =
            from cust3 in Company.Customers
            select new
            {
                Name = cust3.Name
            };

        foreach (var cust3 in customers3)
            Console.WriteLine(cust3.Name);

        var customer = new Customer();

        var response = DoSomethingAndReturnResults();

        var customers4 =
            from cust4 in Company.Customers
            where cust4.Name.Length > 3 && !cust4.Name.StartsWith("G")
            select cust4;

        foreach (var cust4 in customers4)
            Console.WriteLine(cust4.Name);

        var customers5 =
            from cust5 in Company.Customers
            orderby cust5.Name descending
            select cust5;

        foreach (var cust5 in customers5)
            Console.WriteLine(cust5.Name);

        var customerOrders =
            from cust in Company.Customers
            join ord in Company.Orders
                on cust.ID equals ord.CustomerID
            select new
            {
                ID = cust.ID,
                Customer = cust.Name,
                Item = ord.Description
            };

        foreach (var custOrd in customerOrders)
            Console.WriteLine(
                $"Customer: {custOrd.Customer}, Item: {custOrd.Item}");

        var customerOrders2 =
            from cust in Company.Customers
            join ord in Company.Orders.DefaultIfEmpty()
                on cust.ID equals ord.CustomerID
            select new
            {

                ID = cust.ID,
                Customer = cust.Name,
                Item = ord.Description
            };

        foreach (var custOrd2 in customerOrders)
            Console.WriteLine(
                $"Customer: {custOrd2.Customer}, Item: {custOrd2.Item}");

        Console.ReadKey();
    }

    static int DoSomethingAndReturnResults() => 0;
}
