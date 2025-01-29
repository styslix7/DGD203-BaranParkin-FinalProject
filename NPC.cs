using System;

public class NPC
{
    public string Name { get; private set; }
    public string Dialogue { get; private set; }

    public NPC(string name, string dialogue)
    {
        //here are NPC variables
        Name = name;
        Dialogue = dialogue;
    }

    public void Speak()
    {
        //as told in description, each class was put in a different file
        Console.WriteLine($"{Name}: {Dialogue}");
    }
}

