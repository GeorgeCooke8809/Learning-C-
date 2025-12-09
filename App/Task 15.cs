/* Write a function that asks the  user to input  their age. If the age is 15 or less, display the message “You are 
entitled to purchase a child’s ticket”. Otherwise, display “You must buy and adult ticket!” Show  that  the 
program works correctly with the inputs of 14, 15 and 16 */

public static class Task15
{
    public static void Run()
    {
        int age = -1;
        Console.Write("Age: ");
        string? age_input = Console.ReadLine();

        int.TryParse(age_input, out age); // Converts string into integer or passes if not possible. Better that the if I was using.

        if (age <= 15 && age >= 0)
        {
            Console.WriteLine("You are entitled to purchase a child's ticket.");
        }
        else if (age < 0)
        {
            Console.WriteLine("That was an invalid input.");
        }
        else
        {
            Console.WriteLine("You must buy an adult ticket.");
        }
    }
}