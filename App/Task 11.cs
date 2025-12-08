/* Write a function to read in the amount of gross pay that the employee has earned. Calculate and display 
the amount of tax due (at 25%) and the amount of net pay (gross – tax). Run your function to show that it 
works with a gross pay figure of £375. */

public static class Task11
{
    public static void Run()
    {
        float earnings = 0;
        float[,] tax_brackets = {{12570, 0}, {50270, 0.2f}, {125140, 0.4f}, {1000000000000, 0.45f}};
        Console.Write("Yearly Earnings (Gross Pay): £");
        string? earnings_input = Console.ReadLine();

        if (earnings_input != null)
        {
            earnings = float.Parse(earnings_input);
        }

        float total_tax = 0;
        float original_earnings = earnings;

        for (int i = 0; i < tax_brackets.Length; i++)
        {
            if (earnings > 0)
            {
                float taxable_amount = 12570;

                if (i > 0)
                {
                    taxable_amount = tax_brackets[i,0] - tax_brackets[i-1,0];
                }
                if (taxable_amount > earnings)
                {
                    taxable_amount = earnings;
                }
                float iteration_tax = taxable_amount * tax_brackets[i,1];
                total_tax = total_tax + iteration_tax;
                earnings = earnings - taxable_amount;
            }
        }

        float total_tax_percentage = total_tax / original_earnings * 100;
        string total_tax_percentage_formatted = String.Format("{0:N2}",total_tax_percentage);
        string total_tax_formatted = String.Format("{0:N2}",total_tax);
        string take_home_formatted = String.Format("{0:N2}",original_earnings - total_tax);
        Console.WriteLine($"Total Tax To Pay: £{total_tax_formatted}");
        Console.WriteLine($"Total Tax Percentage: {total_tax_percentage_formatted}%");
        Console.WriteLine($"Net Income: £{take_home_formatted}");
    }
}