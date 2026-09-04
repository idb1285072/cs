using System;

class Sample
{
    static void Main()
    {
        Product product1, product2, product3;
        product1 = new Product();
        Product.totalProducts++;
        product2 = new Product();
        Product.totalProducts++;
        product3 = new Product();
        Product.totalProducts++;

        product1.productId = 1001;
        product1.productName = "Mobile";
        product1.price = 15000;
        product1.quantityInStock = 1200;

        product2.productId = 1002;
        product2.productName = "Laptop";
        product2.price = 55000;
        product2.quantityInStock = 3400;

        product3.productId = 1003;
        product3.productName = "Tablet";
        product3.price = 25000;
        product3.quantityInStock = 2200;

        // Display product details
        System.Console.WriteLine("Product 1 Details:");
        System.Console.WriteLine("Product ID: " + product1.productId);
        System.Console.WriteLine("Product Name: " + product1.productName);
        System.Console.WriteLine("Price: " + product1.price);
        System.Console.WriteLine("Quantity in Stock: " + product1.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + product1.dateOfPurchase);

        System.Console.WriteLine("Product 2 Details:");
        System.Console.WriteLine("Product ID: " + product2.productId);
        System.Console.WriteLine("Product Name: " + product2.productName);
        System.Console.WriteLine("Price: " + product2.price);
        System.Console.WriteLine("Quantity in Stock: " + product2.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + product2.dateOfPurchase);

        System.Console.WriteLine("Product 3 Details:");
        System.Console.WriteLine("Product ID: " + product3.productId);
        System.Console.WriteLine("Product Name: " + product3.productName);
        System.Console.WriteLine("Price: " + product3.price);
        System.Console.WriteLine("Quantity in Stock: " + product3.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + product3.dateOfPurchase);


        int totalQuantity = product1.quantityInStock + product2.quantityInStock + product3.quantityInStock;
        System.Console.WriteLine("Total Quantity in Stock: " + totalQuantity);


        decimal expensiveProductPrice = Math.Max(product1.price, Math.Max(product2.price, product3.price));
        System.Console.WriteLine("Highest Product Price: " + expensiveProductPrice);

        System.Console.WriteLine("Total Products Created: " + Product.totalProducts);
        System.Console.WriteLine("Company Name: " + Product.companyName);

        const string developerName = "Raj Khan";
        System.Console.WriteLine("Developer Name: " + developerName);

        System.Console.ReadLine();
    }
}

public class  InternationalProduct: Product
{
    
}

public class OtherClass2
{

}