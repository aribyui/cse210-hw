public class Product
{
    private string _productName = "";
    private string _productId = "0";
    private double _price = 0;
    private int _quantity = 0;

    public Product()
    {

    }

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public void SetProductId(string productId)
    {
        _productId = productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public double GetProductPrice()
    {
        return _price * _quantity;
    }

    // public void DisplayNameAndID()
    // {
    //     Console.WriteLine($"Product: {_productName}\nID: {_productId}");
    // }

    public void DisplayNameAndID(int count)
    {
        Console.WriteLine($"{count}. {_productName}\nID: {_productId}");
    }
}