using System;
namespace FirstTestProject_IBM;

internal class Product
{
    // Data Members
    private string productName;
    private double productPrice;
    private int productQuantity;
    // Default Constructor
    public Product() { }
    // Parameterized Constructor                                    // Setting the initial values for the product
    public Product(string name, double price, int quantity)
    {
        productName = name;
        productPrice = price;
        productQuantity = quantity;
    }
    // Properties
    public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }
    public double ProductPrice
    {
        get { return productPrice; }
        set { productPrice = value; }
    }
    public int ProductQuantity
    {
        get { return productQuantity; }
        set { productQuantity = value; }
    }
    // Method to display product details
    public void DisplayProductDetails()
    {
        Console.WriteLine();
        Console.WriteLine($"Product Name: {productName}");
        Console.WriteLine($"Product Price: {productPrice}");                                  // TO CHANGE
        Console.WriteLine($"Product Quantity: {productQuantity}");
    }
    // Method to calculate total price
    public double CalculateTotalPrice()
    {
        Console.WriteLine();
        return productPrice * productQuantity;
    }
    // Method to apply discount
    public double ApplyDiscount(double discountPercentage)
    {
        Console.WriteLine();
        double discountAmount = (discountPercentage / 100) * productPrice;
        return productPrice - discountAmount;
    }
    // Method to check stock availability
    public bool IsInStock()
    {
        Console.WriteLine();
        return productQuantity > 0;
    }
    // Method to restock product
    public void Restock(int additionalQuantity)
    {
        Console.WriteLine();
        if (additionalQuantity > 0)
        {
            productQuantity += additionalQuantity;
            Console.WriteLine($"{additionalQuantity} units added to stock.");
        }
        else
        {
            Console.WriteLine("Invalid quantity for restocking.");
        }
    }
    // Method to sell product
    public void Sell(int quantityToSell)
    {
        Console.WriteLine();
        if (quantityToSell > 0 && quantityToSell <= productQuantity)
        {
            productQuantity -= quantityToSell;
            Console.WriteLine($"{quantityToSell} units sold.");
        }
        else if (quantityToSell > productQuantity)
        {
            Console.WriteLine("Insufficient stock to sell the requested quantity.");
        }
        else
        {
            Console.WriteLine("Invalid quantity for selling.");
        }
    }
    // Method to update product price
    public void UpdatePrice(double newPrice)
    {
        Console.WriteLine();
        if (newPrice >= 0)
        {
            productPrice = newPrice;
            Console.WriteLine($"Product Price updated to {productPrice}");
        }
        else
        {
            Console.WriteLine("Invalid Price. Price can't be Negative.");
        }
    }
}






