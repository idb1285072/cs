class Method
{
    static void Main()
    {
        // Declare reference variable of Product type
        Product p1, p2, p3;

        // Create Product Object and assign into reference variable
        p1 = new Product();
        Product.SetTotalNumberOfProdcuts(Product.GetTotalNumberOfProducts() + 1);
        p2 = new Product();
        Product.SetTotalNumberOfProdcuts(Product.GetTotalNumberOfProducts() + 1);
        p3 = new Product();
        Product.SetTotalNumberOfProdcuts(Product.GetTotalNumberOfProducts() + 1);

        // Initialization value
        p1.SetProductId(1001);
        p1.SetProductName("Mobile");
        p1.SetPrice(20000);
        p1.SetQuantityInStock(1200);

        p2.SetProductId(1002);
        p2.SetProductName("Laptop");
        p2.SetPrice(45000);
        p2.SetQuantityInStock(34000);

        p3.SetProductId(1003);
        p3.SetProductName("Speakers");
        p3.SetPrice(36000);
        p3.SetQuantityInStock(800);

        // call method
        p1.CalculateTax();
        p2.CalculateTax(7.4);
        p3.CalculateTax(percentage: 12.5);

        // Display 
        System.Console.WriteLine("Product 1:");
        System.Console.WriteLine("Product Id: " + p1.GetProductId());
        System.Console.WriteLine("Product Name: " + p1.GetProductName());
        System.Console.WriteLine("Price: " + p1.GetPrice());
        System.Console.WriteLine("Quantity in Stock: " + p1.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + p1.GetDateOfPurchese());
        System.Console.WriteLine("Tax: " + p1.GetTax());
        System.Console.WriteLine();

        System.Console.WriteLine("Product 2:");
        System.Console.WriteLine("Product Id: " + p2.GetProductId());
        System.Console.WriteLine("Product Name: " + p2.GetProductName());
        System.Console.WriteLine("Price: " + p2.GetPrice());
        System.Console.WriteLine("Quantity in Stock: " + p2.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + p2.GetDateOfPurchese());
        System.Console.WriteLine("Tax: " + p2.GetTax());
        System.Console.WriteLine();

        System.Console.WriteLine("Product 3:");
        System.Console.WriteLine("Product Id: " + p3.GetProductId());
        System.Console.WriteLine("Product Name: " + p3.GetProductName());
        System.Console.WriteLine("Price: " + p3.GetPrice());
        System.Console.WriteLine("Quantity in Stock: " + p3.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + p3.GetDateOfPurchese());
        System.Console.WriteLine("Tax: " + p3.GetTax());
        System.Console.WriteLine();

        // Total Quantity
        int totalQuantity = Product.GetTotalQuantity(p1, p2, p3);
        System.Console.WriteLine("Total Quantity in Stock: " + totalQuantity);

        // Highest cost of all three products
        decimal highestCost = GetMax(p1.GetPrice(), p2.GetPrice(), p3.GetPrice());
        System.Console.WriteLine("Highest Price: " + highestCost);

        // Total Number of Products
        System.Console.WriteLine("Total number of Products: " + Product.GetTotalNumberOfProducts());
        System.Console.WriteLine("Category Name: " + Product.CategoryName);

        // Local Constant 
        // premetive type and string
        const string developerName = "Md. Murad Hossen";
        System.Console.WriteLine(developerName);


        System.Console.ReadKey();
    }
    static decimal GetMax(params decimal[] values)
    {
        decimal highest = values[0];
        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] > highest) highest = values[i];
        }
        return highest;
    }
}