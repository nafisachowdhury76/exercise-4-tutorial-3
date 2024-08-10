using System;
using System.Collections.Generic;

public class Product
{
    public int productId;
    public string productName;
    public double price;
    public string category;  // New property

    public Product(int id, string name, double price, string category)
    {
        productId = id;
        productName = name;
        this.price = price;
        this.category = category;  // Initialize the new property
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
            Console.WriteLine($"Product ID: {product.productId}, Name: {product.productName}, Price: ${product.price}, Category: {product.category}");
        }
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (var product in shoppingList)
        {
            total += product.price;
        }
        return total;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Customer object
        Customer Cust1 = new Customer(1, "Oliver Brown", "oliver.brown@example.com");

        // Create Product objects
        Product prod1 = new Product(101, "Laptop", 1200.00, "Electronics");
        Product prod2 = new Product(102, "Smartphone", 800.00, "Electronics");

        // Add products to Cust1's shopping list
        Cust1.AddProduct(prod1);
        Cust1.AddProduct(prod2);

        // Print the shopping list of Cust1
        Cust1.PrintShoppingList();

        // Calculate and print the total cost
        double totalCost = Cust1.CalculateTotalCost();
        Console.WriteLine($"Total cost of the shopping list: ${totalCost}");
    }
}
