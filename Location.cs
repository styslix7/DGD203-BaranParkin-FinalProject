using System;

public class Location
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public LocationInteraction Interaction { get; private set; }

    public Location(string name, string description, LocationInteraction interaction)
    {
        //here are variables that will depend on players location
        Name = name;
        Description = description;
        Interaction = interaction;
    }

    public void Describe()
    {
        Console.WriteLine($"{Name}: {Description}");
    }

    public void Interact()
    {
        if (Interaction != null)
        {
            //interaction mechanics
            Console.WriteLine(Interaction.Prompt);
            Interaction.Action.Invoke();
        }
    }
}

public class LocationInteraction
{
    public string Prompt { get; private set; }
    public Action Action { get; private set; }

    public LocationInteraction(string prompt, Action action)
    {
        Prompt = prompt;
        Action = action;
    }
}

