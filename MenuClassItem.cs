using System;

public class MenuItem
{
    // Fields
    public string Name { get; private set; }               // Name of the menu item
    public decimal Price { get; private set; }             // Price of the item
    public string Description { get; private set; }        // Description of the item
    public string Category { get; private set; }           // Category (e.g., appetizer, main course, dessert)
    public bool IsNew { get; private set; }                // Flag to indicate if the item is new
    public MenuItem(string name, decimal price, string description, string category, bool isNew)
    {
        Name = name;
        Price = price;
        Description = description;
        Category = category;
        IsNew = isNew;
    }

    // Method to display item details
    public void DisplayItem()
    {
        string newStatus = IsNew ? " (New!)" : "";
        Console.WriteLine($"{Name} - ${Price} - {Category}{newStatus}");
        Console.WriteLine(Description);
        Console.WriteLine();
    }
}
