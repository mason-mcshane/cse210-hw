using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("321 Main St.", "New York", "NY");
        Address address2 = new Address("1871 E Del Rio DR.", "Tempe AZ","USA");

        Customer customer1 = new Customer("Mark Goaslind", address1);
        Customer customer2 = new Customer("Mike Phelps", address2);
 
        Product product1 = new Product("Copy of the Book of Mormon","P001", 5.00, 10);
        Product product2 = new Product("Triple Combination","P002", 30.00,10);
        Product product3 = new Product("The King James Bible","P003", 45.00, 10);
        Product product4 = new Product("Pamphlets","P004", 2.00, 30);

        Order order1 = new Order(customer1);
        order1.Addproduct(product1);
        order1.Addproduct(product3);

        Order order2 = new Order(customer1);
        order2.Addproduct(product2);
        order2.Addproduct(product4);
        order2.Addproduct(product1);

        Console.WriteLine("Order 1 ");
        Console.WriteLine("Parking Label");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine();

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.ShippingLabel());

        Console.WriteLine("TOTAL PRICE");
        Console.WriteLine(order1.GetTotalCost());
        Console.WriteLine("-----------------------------");

        Console.WriteLine("Order 2 ");
        Console.WriteLine("Parking Label");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine();

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.ShippingLabel());

        Console.WriteLine("TOTAL PRICE");
        Console.WriteLine(order2.GetTotalCost());
    }
}