public class Product
{
    private int productId;
    private string productName;
    private decimal cost;
    private int quantityInStock;
    private decimal tax;
    private readonly string dateOfPurchase;
    public static int totalNumberOfProducts;

    public void CalculateTax(decimal percentage = 12.5m)
    {
        decimal taxAmount;
        if (this.cost <= 20000)
        {
            taxAmount = cost * 0.01m;
        }
        else 
        {
            taxAmount = this.cost * percentage / 100;
        }
        this.tax = taxAmount;
    }
    public void CalculateTax(decimal cost, decimal percentage = 12.5m)
    {
        decimal taxAmount;
        if (this.cost <= 20000)
        {
            taxAmount = cost * 0.01m;
        }
        else 
        {
            taxAmount = this.cost * percentage / 100;
        }
        this.tax = taxAmount;
    }


    // set method for productId
    public void SetProductId(int productId)
    {
        this.productId = productId;
    }

    // get method for productId
    public int GetProductId()
    {
        return productId;
    }

    public void SetProductName(string productName)
    {
        this.productName = productName;
    }
    public string GetProductName()
    {
        return this.productName;
    }

    public void SetCost(decimal cost)
    {
        this.cost = cost;
    }
    public decimal GetCost()
    {
        return cost;
    }

    public void SetQuantityInStock(int quantity)
    {
        quantityInStock = quantity;
    }
    public int GetQuantityInStock()
    {
        return quantityInStock;
    }
    public void SetTax(decimal tax)
    {
        this.tax = tax;
    }
    public decimal GetTax()
    {
        return tax;
    }
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }

    public static void SetTotalNumberOfProducts(int totalNumberOfProducts)
    {
        Product.totalNumberOfProducts = totalNumberOfProducts;
    }

    public static int GetTotalNumberOfProducts()
    {
        return totalNumberOfProducts;
    }

    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        return product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
    }

}