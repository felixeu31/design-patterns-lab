// See https://aka.ms/new-console-template for more information

using ConsoleAppStrategyPattern.StrategyPattern;
using ConsoleAppStrategyPattern.Utils;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to this fantastic console application");
Console.WriteLine(@"This application implements the strategy pattern to execute different implementations. 
                    It is useful when you want to to test several implementations very quickly");

var strategyManager = new StrategyManager();
strategyManager.AskAndExecuteStrategy();

ConsoleUtils.AskForExit();

 

