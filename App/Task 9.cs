/* Write a function to handle holiday spending  by carrying out the following steps:  
• Set a variable to store the initial amount of holiday spending money (50,000)  
• Output the title ‘Italian Holiday’ 
• Output  the  number of euros at the start of the holiday 
• Read in the number of euros spent  on food 
• Read in the number of euros spent  on trips 
• Read in the number of euros spent  on presents 
Output  the  amount of money  left */

public static class Task9
{
    public static void Run()
    {
        float funds = 50000;
        string funds_formatted = String.Format("{0:N2}",funds);
        Console.WriteLine($"Italian Holiday:\nStarting Funds: £{funds_formatted}");
        string[] spending_categories = ["Food", "Trips", "Presents"];

        for (int i = 0; i < spending_categories.Length; i++)
        {
            float spend = 0;
            Console.Write($"Spending On {spending_categories[i]}: £");
            string? user_spend_input = Console.ReadLine();

            if (user_spend_input != null)
            {
                spend = float.Parse(user_spend_input);
                funds = funds - spend;
            }
        }
        funds_formatted = String.Format("{0:N2}",funds);
        Console.WriteLine($"Remaining Funds At The End Of Holiday: £{funds_formatted}");
    }
}