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
        
        Address address1 = new Address("Villa 1878", "Monterrey", "Nuevo León", "México");

        Customer customer1 = new Customer("Lizandro Arizpe", address1);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order1.PackingLabel();

        Console.WriteLine(); // line break

        order1.ShippingLabel(address1);

        Console.WriteLine(); // line break

        order1.TotalOrderCost();
        
        Console.WriteLine("_______________________________________________________\n"); // line break

        Console.WriteLine("Order 2\n");

        Product product4 = new Product("Kuesuny - 4GB DDR3 1333 SODIMM RAM", "B07Q1PG4M1", 15.06, 2);
        Product product5 = new Product("Kingston SSD A400 480GB", "B01N0TQPQB", 28.63, 2);
        
        Address address2 = new Address("Ángeles 1868", "Laredo", "Texas", "United States", true);

        Customer customer2 = new Customer("Arnaldo Martínez", address2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        order2.PackingLabel();

        Console.WriteLine(); // line break

        order2.ShippingLabel(address2);

        Console.WriteLine(); // line break

        order2.TotalOrderCost();

        Console.WriteLine(); // line break
    }
}