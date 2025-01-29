using System;
using System.Collections.Generic;

public class Inventory
{
    //here is the inventory system
    public List<Item> Items { get; private set; }

    public Inventory()
    {
        Items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
        Console.WriteLine($"{item.Name} added to inventory.");
    }

    public bool HasItem(string itemName)
    {
        return Items.Exists(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
    }
}

public class Item
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    public Item(string name, string description)
    {
        //here is the item variables
        Name = name;
        Description = description;
    }
}

