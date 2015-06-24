using System;

public class ShoppingCart
{
    [Obsolete("Method planned for deprecation on date – use … instead.")]
    public void Add(string item) { }

    [Obsolete("Method is obsolete and can no longer be used", error: true)]
    public decimal CalculateTax(decimal[] prices) { return 0; }
}
