public class Player
{
    public string Name { get; private set; }
    public Inventory Inventory { get; private set; }

    public Player()
    {
        //name it set default for story, it's not a player choice this time
        Name = "Ethan";
        Inventory = new Inventory();
    }
}

