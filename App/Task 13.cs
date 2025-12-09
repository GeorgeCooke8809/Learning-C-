/* Write a function to read in the amount of miles traveled and the amount in litres of fuel used. Calculate 
and display the fuel economy in miles per gallon. Run your function to show that it works with inputs  of 
300 miles and 40 litres of fuel. */

public static class Task13
{
    public static void Run()
    {
        float miles = 0;
        float litres = 0;

        Console.Write("Miles Traveled: ");
        string? miles_input = Console.ReadLine();
        if (miles_input != null)
        {
            miles = float.Parse(miles_input);
        }

        Console.Write("Litres of Fuel Used: ");
        string? litres_input = Console.ReadLine();
        if (litres_input != null)
        {
            litres = float.Parse(litres_input);
        }

        float gallons = litres / 4.54609f;
        float mpg = miles / gallons;

        Console.WriteLine($"Fuel Efficiency: {mpg:F2} Miles Per Gallon");
    }
}