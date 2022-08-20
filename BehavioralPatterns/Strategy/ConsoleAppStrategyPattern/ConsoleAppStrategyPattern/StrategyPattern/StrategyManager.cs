namespace ConsoleAppStrategyPattern.StrategyPattern;

public class StrategyManager
{
    private StrategyContext strategyContext = new StrategyContext();

    public void AskAndExecuteStrategy()
    {
        Console.WriteLine("Please, what strategy do you want to execute? (a/b/c)");
        string response = Console.ReadLine();
        if (response == "a")
        {
            strategyContext.SetStrategy(new StrategyA());
            strategyContext.ExecuteStrategy();
        }
        else if (response == "b")
        {
            strategyContext.SetStrategy(new StrategyB());
            strategyContext.ExecuteStrategy();
        }
        else if (response == "c")
        {
            strategyContext.SetStrategy(new StrategyC());
            strategyContext.ExecuteStrategy();
        }
        else
        {
            Console.WriteLine("Sorry, that was not a valid strategy.");
            AskAndExecuteStrategy();
        }
    }
}