using System;

class Discount
{
    /*
       The Open/Closed Principle (OCP) states that a class should be open for extension
       (adding new features) but closed for modification (changing existing code).
    */

    /*
    ❌ Without OCP
    Suppose you want to calculate discounts.
    Problem

    If a new customer type (e.g., Gold) is added, you must modify the GetDiscount() method.
    This violates the Open/Closed Principle.
    */
    public double GetDiscount(string customerType, double amount)
    {
        if (customerType == "Regular")
            return amount * 0.10;

        if (customerType == "Premium")
            return amount * 0.20;

        return 0;
    }
}

class Program
{
    static void Main()
    {
        Discount discount = new Discount();

        Console.WriteLine(discount.GetDiscount("Regular", 1000));
        Console.WriteLine(discount.GetDiscount("Premium", 1000));
    }
}

/*
using System;

// Base class
abstract class Discount
{
    public abstract double GetDiscount(double amount);
}

// Regular customer discount
class RegularDiscount : Discount
{
    public override double GetDiscount(double amount)
    {
        return amount * 0.10;
    }
}

// Premium customer discount
class PremiumDiscount : Discount
{
    public override double GetDiscount(double amount)
    {
        return amount * 0.20;
    }
}

class Program
{
    static void Main()
    {
        Discount regular = new RegularDiscount();
        Discount premium = new PremiumDiscount();

        Console.WriteLine("Regular Discount: " + regular.GetDiscount(1000));
        Console.WriteLine("Premium Discount: " + premium.GetDiscount(1000));
    }
}

*/
/*
Adding a New Customer (No Existing Code Changes)

Just create a new class:

class GoldDiscount : Discount
{
    public override double GetDiscount(double amount)
    {
        return amount * 0.30;
    }
}

Now you can use:

Discount gold = new GoldDiscount();
Console.WriteLine(gold.GetDiscount(1000));

Notice that you did not modify RegularDiscount, PremiumDiscount, or Program.

*/