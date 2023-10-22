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

        double shippingCost;
        
        if (_customer.LiveInUSA())
        {
            /* 
            If the customer lives in the USA, 
            the shipping cost is $5
            total += shipping cost
            */
            shippingCost = 5;
            total += shippingCost;
        }
        else
        {
            /*
            If the customer does not live in the USA, 
            the shipping cost is $35.
            total += shipping cost
            */
            shippingCost = 35;
            total += shippingCost;
        }

        Console.WriteLine($"Total: ${total}");    
    }

    public void PackingLabel()
    {
        int count = 0;

        foreach (Product p in _products)
        {
            count++;
            p.DisplayNameAndID(count);
        }
    }
    
    public void ShippingLabel(Address address)
    {   
        _customer.DisplayName();
        address.DisplayAddress();
    }
}