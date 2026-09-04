using ExtensionMethod;
using System;

class ExtensionMethods
{
    static void Main()
    {
        Product product = new Product
        {
            ProductCost = 100m,
            DiscountPrice = 80m
        };
        Console.WriteLine($"Discount: {product.GetDiscount()}");

        Console.ReadKey();
    }
}

public static class ProductExtensions
{
    public static decimal GetDiscount(this Product product)
    {
        return product.ProductCost - product.DiscountPrice;
    }
}