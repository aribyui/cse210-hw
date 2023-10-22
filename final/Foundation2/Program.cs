using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Order 1\n");

        Product product1 = new Product("Xiaomi Smartphone Redmi Note 11s", "B09R4F1LW4", 175.43, 2);
        Product product2 = new Product("Cooler Master MasterFan SF120M", "B07Y48W3RG", 20.70, 3);
        Product product3 = new Product("Zotac Gaming GeForce RTX 3060 Twin Edge OC 12GB", "B08W8DGK3X", 290.65, 1);
        
        Address address = new Address("Rosas 3468", "Monterrey", "Nuevo León", "México", true);

        Customer customer1 = new Customer("Lizandro Arizpe", address);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order1.PackingLabel();

        Console.WriteLine(); // line break

        order1.ShippingLabel(address);

        Console.WriteLine(); // line break

        order1.TotalOrderCost();
        
        Console.WriteLine(); // line break
    }
}