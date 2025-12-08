/* Write a function to read in the amount of the bill and the amount of money tendered.  Calculate and 
display the amount  of change due to the  customer . Run your function  to  show  that it works with  a bill 
amount  of £8.50 and an amount tendered  of £10. */

public static class Task7
{

    public static void Run()
    {
        float cash = 0;
        Console.Write("Cash Given: £");
        string? user_input = Console.ReadLine();
        if (user_input != null)
        {
            cash = float.Parse(user_input);
        }

        float bill = 0;
        Console.Write("Bill: £");
        user_input = Console.ReadLine();
        if (user_input != null)
        {
            bill = float.Parse(user_input);
        }

        float? change = cash - bill;
        Console.WriteLine($"Change Due: £{change:F2}");
    }
}