using System;
using System.Numerics;

public class GameManager
{
    public static Player player;

    public static void StartNewGame()
    {
        //here the game starts, this part is long because it has a lot of dialogue for story but all are basic printing dialogue on screen
        player = new Player();
        Console.Clear();
        Console.WriteLine("New Game Starting...");
        ShowMap();
    }

    private static void ShowMap()
    {
        Console.WriteLine("You are on a spaceship exploring the galaxy. Choose a planet to visit.");

        //locations are here
        Location planet1 = new Location("Ardena", "A lush, forest-covered planet with ancient ruins.",
            new LocationInteraction("You arrive at Ardena. It’s known for its beauty and mysterious ruins.", () => ExploreRuins()));

        Location planet2 = new Location("Xylor", "A harsh desert world with towering crystalline mountains.",
            new LocationInteraction("You land on Xylor. The blistering heat hits you as you step out.", () => MeetTheNomads()));

        Location planet3 = new Location("Juxara", "A frozen moon orbiting a gas giant. Its surface is barren and icy.",
            new LocationInteraction("Juxara is a cold, desolate world. The ice stretches out for miles.", () => InvestigateIceCaves()));

        Location planet4 = new Location("Verta", "An industrialized world, buzzing with machines and technology.",
            new LocationInteraction("Verta is a high-tech planet. The sound of machines fills the air as you explore the city.", () => VisitTheFactory()));

        Location planet5 = new Location("Eldara", "A mystical planet shrouded in dense fog. Many explorers never return.",
            new LocationInteraction("You arrive at Eldara, a world wrapped in mystery and fog. Strange lights flicker in the distance.", () => EncounterTheFog()));

        //lists callings
        planet1.Describe();
        planet1.Interact();
    }

    private static void ExploreRuins()
    {
        Console.WriteLine("You step into the ruins of an ancient civilization, your footsteps echoing in the silent halls.");
        NPC guardian = new NPC("Guardian", "I have been waiting for someone like you. To pass, you must solve the riddle of the old king.");
        guardian.Speak();
    }

    private static void MeetTheNomads()
    {
        Console.WriteLine("The blistering heat on Xylor makes it almost unbearable. You approach a group of nomads who seem to have adapted.");
        NPC nomad = new NPC("Nomad Leader", "We survive by reading the stars. I can teach you, if you help us find the lost artifact.");
        nomad.Speak();
    }

    private static void InvestigateIceCaves()
    {
        Console.WriteLine("You venture into the icy caves of Juxara. The cold is almost unbearable, but the beauty of the ice formations keeps you moving.");
        NPC iceGuardian = new NPC("Ice Guardian", "Only those who prove their resilience may uncover the secrets of the cave. Are you prepared?");
        iceGuardian.Speak();
    }

    private static void VisitTheFactory()
    {
        Console.WriteLine("You enter the industrialized city of Verta. The air is thick with smog, and machines work tirelessly around you.");
        NPC engineer = new NPC("Engineer", "The machines are alive here. But there's a flaw in the system. Could you help us fix it?");
        engineer.Speak();
    }

    private static void EncounterTheFog()
    {
        Console.WriteLine("Eldara’s thick fog swallows you whole. You can barely see a few feet in front of you. Strange sounds echo in the distance.");
        NPC spirit = new NPC("Spirit", "Only those who are not afraid of the unknown can find the truth hidden in the fog. Do you dare?");
        spirit.Speak();
    }
}

//as said while this part is long, it's all printing dialogue on screen so there is no need to describe the scripts