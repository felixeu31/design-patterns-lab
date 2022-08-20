namespace ConsoleAppStrategyPattern.StrategyPattern;

public class StrategyA : Strategy
{
    public void Execute()
    {
        Console.WriteLine("This is the strategy A being executed");
    }
}