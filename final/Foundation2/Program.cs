using System;

class Program
{
    static void Main(string[] args)
    {
        // create some products
        var product1 = new Product("Apple Watch", "111222", 180.00, 3);
        var product2 = new Product("iPad 3", "2223333", 580, 2);
        var product3 = new Product("MacBook Pro", "202020", 1450.15, 1);

        // create some addresses
        var address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        var address2 = new Address("456 LiLy Road", "Rigby", "ID", "USA");
        var address3 = new Address("Manoel Pereira do Limoeir, 410", "Londrina", "PR", "Brazil");

        // create some customers
        var customer1 = new Customer("Jake", address1);
        var customer2 = new Customer("Mark", address2);
        var customer3 = new Customer("Cleusa", address3);

        // create some orders
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // display the packing labels, shipping labels, and total prices for the orders
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total cost: {0:C}", order1.CalculateTotalCost());
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total cost: {0:C}", order2.CalculateTotalCost());
    }
}
