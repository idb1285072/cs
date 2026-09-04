public class Product
{
    //private int productId;
    //private string productName;
    //private decimal price;
    //private int quantityInStock;
    //private decimal tax;
    public int productId;
    public string productName;
    public decimal price;
    public int quantityInStock;
    public decimal tax;
    public static int TotalNumberOfProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;
    //private readonly string dateOfPurchase;

    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    // method
    public void CalculateTax(double percentage = 12.5)
    {
        // create local variable
        decimal t;
        if (price <= 20000)
        {
            t = price * 10 / 100;
        }
        else
        {
            t = price * (decimal)percentage / 100;
        }
        tax = t;
    }


    public void SetProductId(int id)
    {
        productId = id;
    }
    public int GetProductId()
    {
        return productId;
    }
    public void SetProductName(string name)
    {
        productName = name;
    }
    public string GetProductName()
    {
        return productName;
    }
    public void SetPrice(decimal price)
    {
        this.price = price;
    }
    public decimal GetPrice()
    {
        return price;
    }
    public void SetQuantityInStock(int quantityInStock)
    {
        this.quantityInStock = quantityInStock;
    }
    public int GetQuantityInStock()
    {
        return quantityInStock;
    }
    public decimal GetTax()
    {
        return tax;
    }
    public string GetCategoryName()
    {
        return CategoryName;
    }
    public string GetDateOfPurchese()
    {
        return dateOfPurchase;
    }

    // Static Method
    public static void SetTotalNumberOfProdcuts(int value)
    {
        TotalNumberOfProducts = value;
    }

    public static int GetTotalNumberOfProducts()
    {
        return TotalNumberOfProducts;
    }

    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        return product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock(); ;
    }
}
