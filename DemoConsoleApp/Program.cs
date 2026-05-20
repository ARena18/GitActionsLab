namespace DemoConsoleApp;

public static class Calculator
{
    public static int Add(int a, int b) => a + b;
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine($"2 + 3 = {Calculator.Add(2,3)}");
    }
}