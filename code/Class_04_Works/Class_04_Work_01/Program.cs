class Sample
{
    static void Main()
    {
        Product product1, product2, product3;

        product1 = new Product();
        Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts() + 1);
        product2 = new Product();
        Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts() + 1);
        product3 = new Product();
        Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts() + 1);

        //product1.productId = 1001;
        product1.SetProductId(1001);
        product1.SetProductName("Laptop");
        product1.SetQuantityInStock(3030);
        product1.SetCost(80000.00m);
        //product1.productName = "Laptop";
        //product1.cost = 80000.00m;
        //product1.quantityInStock = 3030;
        //product2.productId = 1002;
        //product2.productName = "Mobile";
        product2.SetProductId(1002);
        product2.SetProductName("Mobile");
        product2.SetCost(30000.00m);
        product2.SetQuantityInStock(5000);
        product3.SetProductId(1003);
        product3.SetProductName("Tablet");
        product3.SetCost(20000.00m);
        product3.SetQuantityInStock(2000);

        product1.CalculateTax(21);
        product2.CalculateTax();
        product3.CalculateTax(18.5m);

        System.Console.WriteLine("Product 1 Details");
        System.Console.WriteLine("Product ID: " + product1.GetProductId());
        System.Console.WriteLine("Product Name: " + product1.GetProductName());
        System.Console.WriteLine("Product Cost: " + product1.GetCost());
        System.Console.WriteLine("Product Quantity In Stock: " + product1.GetQuantityInStock());
        System.Console.WriteLine("Product Tax: " + product1.GetTax());

        System.Console.WriteLine("Product 2 Details");
        System.Console.WriteLine("Product ID: " + product2.GetProductId());
        System.Console.WriteLine("Product Name: " + product2.GetProductName());
        System.Console.WriteLine("Product Cost: " + product2.GetCost());
        System.Console.WriteLine("Product Quantity In Stock: " + product2.GetQuantityInStock());
        System.Console.WriteLine("Product Tax: " + product2.GetTax());

        System.Console.WriteLine("Product 3 Details");
        System.Console.WriteLine("Product ID: " + product3.GetProductId());
        System.Console.WriteLine("Product Name: " + product3.GetProductName());
        System.Console.WriteLine("Product Cost: " + product3.GetCost());
        System.Console.WriteLine("Product Quantity In Stock: " + product3.GetQuantityInStock());
        System.Console.WriteLine("Product Tax: " + product3.GetTax());
        System.Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());

        System.Console.WriteLine("Total Number of Products: " + Product.GetTotalNumberOfProducts());

        // Calculate total quantity of products
        int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);
        System.Console.WriteLine("Total Quantity of Products: " + totalQuantity);

        System.Console.ReadKey();
    }
}