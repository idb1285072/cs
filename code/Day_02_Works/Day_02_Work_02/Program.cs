class Field
{
    static void Main()
    {
        // Declare reference variable of Product type
        Product p1, p2, p3;

        // Create Product Object and assign into reference variable
        p1 = new Product();
        Product.TotalNumberOfProducts++;
        p2 = new Product();
        Product.TotalNumberOfProducts++;
        p3 = new Product();
        Product.TotalNumberOfProducts++;

        // Initialization value
        p1.productId = 1001;
        p1.productName = "Mobile";
        p1.price = 20000;
        p1.quantityInStock = 1200;

        p2.productId = 1002;
        p2.productName = "Laptop";
        p2.price = 45000;
        p2.quantityInStock = 34000;

        p3.productId = 1003;
        p3.productName = "Speakers";
        p3.price = 36000;
        p3.quantityInStock = 800;

        // Display 
        System.Console.WriteLine("Product 1:");
        System.Console.WriteLine("Product Id: " + p1.productId);
        System.Console.WriteLine("Product Name: " + p1.productName);
        System.Console.WriteLine("Price: " + p1.price);
        System.Console.WriteLine("Quantity in Stock: " + p1.quantityInStock);
        System.Console.WriteLine("Date of Purchase: "+p1.dateOfPurchase);
        System.Console.WriteLine();

        System.Console.WriteLine("Product 2:");
        System.Console.WriteLine("Product Id: " + p2.productId);
        System.Console.WriteLine("Product Name: " + p2.productName);
        System.Console.WriteLine("Price: " + p2.price);
        System.Console.WriteLine("Quantity in Stock: " + p2.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + p2.dateOfPurchase) ;
        System.Console.WriteLine();

        System.Console.WriteLine("Product 3:");
        System.Console.WriteLine("Product Id: " + p3.productId);
        System.Console.WriteLine("Product Name: " + p3.productName);
        System.Console.WriteLine("Price: " + p3.price);
        System.Console.WriteLine("Quantity in Stock: " + p3.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + p3.dateOfPurchase) ;

        // Total Quantity
        int totalQuantity = p1.quantityInStock + p2.quantityInStock + p3.quantityInStock;
        System.Console.WriteLine("Total Quantity in Stock: " + totalQuantity);

        // Highest cost of all three products
        decimal highestCost = GetMax(p1.price, p2.price, p3.price);
        System.Console.WriteLine("Highest Price: " + highestCost);

        // Total Number of Products
        System.Console.WriteLine("Total number of Products: " + Product.TotalNumberOfProducts);
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