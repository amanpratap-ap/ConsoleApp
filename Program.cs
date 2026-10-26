using ProductCalculator.Application;

namespace ProductCalculator;

public class Program
{
    public static void Main(string[] args)
    {
        Menu menu = new Menu();

        menu.Run();
    }
}