public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void TotalOrderCost()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.GetProductPrice();  
        }    

        if (_customer.DoesTheCustomerLiveInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        
        Console.WriteLine($"Total: ${total}");    
    }

    public void PackingLabel()
    {
        foreach (Product p in _products)
        {
            p.DisplayNameAndID();
        }
    }
    
    public void ShippingLabel(Address address)
    {   
        _customer.DisplayName();
        address.DisplayAddress();
    }
}