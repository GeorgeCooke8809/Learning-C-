/* Liverpool FC Supporters Club organizes coaches to take members to away matches. Between 8am and 
9am members turn up at the home ground where there is a line of coaches. They always board the front 
coach. When a coach is full, it sets off. At 9am the current front coach sets off, whether or not it is full. 
Write a function to carry out the following tasks: 
  
• Input the total number of club members traveling to a match 
• Input the seating capacity of a coach (assume they are all the same)   
• Output the number of full coaches 
• Output the number of passengers on the last coach */

public static class Task14
{
    public static void Run()
    {
        int club_members = 0;
        int seating_capacity = 0;
        Console.Write("Club Members: ");
        string? club_members_input = Console.ReadLine();
        if (club_members_input != null)
        {
            club_members = int.Parse(club_members_input);
        }

        Console.Write("Seating Capacity: ");
        string? capacity_input = Console.ReadLine();
        if (capacity_input != null)
        {
            seating_capacity = int.Parse(capacity_input);
        }

        int full_coaches = club_members / seating_capacity; // Div - Quotient
        int final_coach = club_members % seating_capacity; // Mod - Remainder

        if (final_coach != 0)
        {
            Console.WriteLine($"Full Coaches: {full_coaches}\nFinal Coach: {final_coach} of {seating_capacity} Seats Filled");
        }
        else
        {
           Console.WriteLine($"Full Coaches: {full_coaches} (All Full)");
        }
    }
}