using System;
using System.Collections.Generic;

public class Menu
{
    // Fields
    public List<MenuItem> Items { get; private set; }             // Collection of menu items
    public DateTime LastUpdated { get; private set; }             // Date of the last update

    // Constructor
    public Menu()
    {
        Items = new List<MenuItem>();
        LastUpdated = DateTime.Now;
    }

    // Method to add a new menu item
    public void AddItem(MenuItem item)
    {
        Items.Add(item);
        LastUpdated = DateTime.Now;   // Update the last updated date
    }

    // Method to display the menu
    public void DisplayMenu()
    {
        Console.WriteLine("Menu (Last updated on: " + LastUpdated.ToShortDateString() + ")\n");

        foreach (var item in Items)
        {
            item.DisplayItem();
        }
    }
}
