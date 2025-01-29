using System;

public class StoryManager
{
    //tracking choices
    private bool hasSolvedPuzzle;  
    private bool hasFoundKey;    
    private bool hasHelpedSylas;   

    public StoryManager()
    {
        //tracking choices
        hasSolvedPuzzle = false;   
        hasFoundKey = false;      
        hasHelpedSylas = false;    
    }

    //to check if ending requirements are met
    public void CheckEnding()
    {
        if (hasSolvedPuzzle && hasFoundKey && hasHelpedSylas)
        {
            GoodEnding();
        }
        else
        {
            BadEnding();
        }
    }

    private void GoodEnding()
    {
        Console.WriteLine("Congratulations! You've unlocked the secrets of the galaxy and saved the universe!");
        Console.WriteLine("With Sylas' help, you discovered the ancient alien technology and unlocked the star map.");
    }

    private void BadEnding()
    {
        Console.WriteLine("Oh no! You were unable to unlock the star map in time. The ancient power remains hidden...");
        Console.WriteLine("Without the key, the universe remains in peril. Better luck next time...");
    }

    //these are functions to be called in situations
    public void SolvePuzzle()
    {
        hasSolvedPuzzle = true;
        Console.WriteLine("You've solved the puzzle! A secret pathway has been unlocked.");
    }

    public void FindKey()
    {
        hasFoundKey = true;
        Console.WriteLine("You've found the Ancient Key! Now you can unlock the mysterious door.");
    }

    public void HelpSylas()
    {
        hasHelpedSylas = true;
        Console.WriteLine("You’ve helped Sylas fix his programming. He now has the knowledge to help you!");
    }
}

