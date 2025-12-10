/* Write a function that inputs  the  names and marks of five students. The function  should  then 
output  a statement saying who has the  highest mark and what that mark is. */

using System.Runtime.CompilerServices;

public static class Task24
{
    public static void Run()
    {
        int highest_mark = 0;
        string highest_student = "";
        
        string user_input = "";

        while (user_input != "Exit")
        {
            Console.Write("Student Name: ");
            string? current_name = Console.ReadLine();

            int current_score;

            if (current_name != "Exit")
            {
                Console.Write("Student Score: ");
                string? current_score_input = Console.ReadLine();

                if (!int.TryParse(current_score_input, out current_score) && current_score_input == "Exit")
                {
                    user_input = "Exit";
                }
                else
                {
                    if (current_score > highest_mark && current_name != null)
                    {
                        highest_mark = current_score;
                        highest_student = current_name;
                    }
                }
            }
            else
            {
                user_input = "Exit";
            }
        }

        Console.WriteLine($"\nBest Student: {highest_student}\nScore: {highest_mark}");
    }
}