namespace ConsoleAppStrategyPattern.StrategyPattern;

public class StrategyB : Strategy
{
    public void Execute()
    {
        Console.WriteLine("This is the strategy B being executed");
    }
}