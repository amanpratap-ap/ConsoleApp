using ProductCalculator.Models;

namespace ProductCalculator.Services;

public class HistoryService
{
    private List<Calculation> calculations = new List<Calculation>();

    public void Add(Calculation calculation)
    {
        calculations.Add(calculation);
    }

    public void Show()
    {
        if (calculations.Count == 0)
        {   
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("No calculations stored.");
            Console.ResetColor();
            return;
        }

        Console.WriteLine("Calculation History:");

        foreach (Calculation calculation in calculations)
        {
            Console.WriteLine(
                $"{calculation.FirstNumber} × {calculation.SecondNumber} = {calculation.Result}");
        }
    }

    public void Clear()
    {
        calculations.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("History cleared.");
        Console.ResetColor();
    }
}