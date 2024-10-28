using System;
using System.Collections.Generic;

namespace RestaurantMenuApp
{
    public class Program
    {
        public static void Main()
        {

            Menu menu = new Menu(); // Creating the menu

            // Create sample menu items
            MenuItem item1 = new MenuItem("Ribeye Steak", 25.99m, "16oz Ribeye Steak Cooked To Order.", "Regular Steak", true);
            MenuItem item2 = new MenuItem("Bone-In Ribeye Steak", 35.99m, "24oz Bone-In Ribeye Steak Cooked To Order.", "Big Boy Steak", false);
            MenuItem item3 = new MenuItem("Filet Mignon Steak", 40.99m, "8oz Filet Mignon Steak Cooked To Order.", "Rich Persons Steak", true);

            // Add items to the menu
            menu.AddItem(item1);
            menu.AddItem(item2);
            menu.AddItem(item3);

            // Display the menu
            menu.DisplayMenu();
        }
    }
}

