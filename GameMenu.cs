using System;

public class GameMenu
{
    public void ShowMenu()
    {
        //here pasting everything on main menu UI
        Console.Clear();
        Console.WriteLine("Welcome to the Interactive Sci-Fi Adventure!");
        Console.WriteLine("1. New Game");
        Console.WriteLine("2. Credits");
        Console.WriteLine("3. Exit");

        //these are for player choices in main menu
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                GameManager.StartNewGame();
                break;
            case "2":
                ShowCredits();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice! Try again.");
                ShowMenu();
                break;
        }
    }

    private void ShowCredits()
    {
        //here is credits part
        Console.Clear();
        Console.WriteLine("Game and story created by Baran Parkın.");
        Console.WriteLine("Took some help from ChatGPT for bug fixing and advanced coding parts");
        Console.WriteLine("Press any key to return.");
        Console.ReadKey();
        ShowMenu();
    }
}