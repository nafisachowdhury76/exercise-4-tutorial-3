using System;
using System.Collections.Generic;

public class Product
{
    public int productId;
    public string productName;
    public double price;

    public Product(int id, string name, double price)
    {
        productId = id;
        productName = name;
        this.price = price;
    }
}

public class Customer
{
    public int id;
    public string name;
    public string email;
    public List<Product> shoppingList;

    public Customer(int customerId, string customerName, string customerEmail)
    {
        id = customerId;
        name = customerName;
        email = customerEmail;
        shoppingList = new List<Product>(); // Initialize the list
    }

    public void AddProduct(Product product)
    {
        shoppingList.Add(product);
    }

    public void PrintShoppingList()
    {
        Console.WriteLine($"{name}'s Shopping List:");
        foreach (var product in shoppingList)
        {
            Console.WriteLine($"Product ID: {product.productId}, Name: {product.productName}, Price: ${product.price}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Customer object
        Customer Cust1 = new Customer(1, "Oliver Brown", "oliver.brown@example.com");

        // Create Product objects
        Product prod1 = new Product(101, "Laptop", 1200.00);
        Product prod2 = new Product(102, "Smartphone", 800.00);

        // Add products to Cust1's shopping list
        Cust1.AddProduct(prod1);
        Cust1.AddProduct(prod2);

        // Print the shopping list of Cust1
        Cust1.PrintShoppingList();
    }
}
