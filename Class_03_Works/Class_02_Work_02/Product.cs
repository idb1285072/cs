public class Product
{
    public int productId;
    public string productName;
    public decimal price;
    public int quantityInStock;
    public static int totalProducts;
    public const string companyName = "ABC Corporation";
    public readonly string productCategory;
    public readonly string dateOfPurchase;
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }
}

public class DomesticProduct : Product
{
    public string domesticRegion;

    public void Method1()
    {
       
    }
}

public class OtherClass1
{
    
}