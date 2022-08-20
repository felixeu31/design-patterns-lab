namespace ConsoleAppStrategyPattern.Utils;

public class ConsoleUtils
{
    public static void AskForExit()
    {
        Console.WriteLine("Do you want to exit? (y/n)");
        string response = Console.ReadLine();
        if (response == "y")
        {
        }
        else if (response == "n")
        {
            Console.WriteLine("That's fantastic. What do you want to do next?");
            AskForExit();
        }
        else
            AskForExit();
    }  
}