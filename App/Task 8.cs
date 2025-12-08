/* Write a function to read in the amount of a restaurant bill and display the amount of tip to be left if the 
percentage tip is 10% or 12.5%. Run your function  to show  the  amounts  on a bill of £87. */

public static class Task8
{
    public static void Run()
    {
        float bill = 0;
        Console.Write("Bill: £");
        string? bill_input = Console.ReadLine();
        if (bill_input != null)
        {
            bill = float.Parse(bill_input);
        }

        float tip_percentage = 0;
        Console.Write("Tip Percentage: ");
        string? tip_input = Console.ReadLine();
        if (tip_input != null)
        {
            tip_percentage = float.Parse(tip_input);
            tip_percentage = tip_percentage / 100;
        }

        float tip_amount = bill * tip_percentage;
        Console.WriteLine($"Tip Amount: £{tip_amount:F2}");
        Console.WriteLine($"Total To Pay: £{bill + tip_amount:F2}");
    }
}