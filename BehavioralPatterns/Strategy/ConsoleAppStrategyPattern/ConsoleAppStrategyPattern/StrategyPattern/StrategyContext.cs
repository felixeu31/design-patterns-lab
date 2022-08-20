namespace ConsoleAppStrategyPattern.StrategyPattern;

public class StrategyContext
{
    private Strategy _strategy;
    
    public void SetStrategy(Strategy strategy) => _strategy = strategy;

    public void ExecuteStrategy() => _strategy?.Execute();
}