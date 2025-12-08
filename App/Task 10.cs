/* Write a function to read in the total GCSE points score and the number of GCSE’s taken. Display the 
average GCSE score. Show the program working with a total score of 61 and number of GCSEs of 11. */

public static class Task10
{
    public static void Run()
    {
        Console.WriteLine("Enter GCSE Scores (Exit To Finish)");
        List<float> grades = new List<float>();
        string? user_choice = "";

        int GCSE_number = 1;

        while (user_choice != "Exit")
        {
            Console.Write($"GCSE Grade In Subject {GCSE_number}: ");
            user_choice = Console.ReadLine();
            if (user_choice != "Exit" && user_choice != null)
            {
                float iteration_grade = float.Parse(user_choice);
                grades.Add(iteration_grade);
                GCSE_number ++;
            }
        }
        float[] grades_array = grades.ToArray();
        Console.WriteLine($"Total GCSEs: {grades_array.Length}");
        float total_score = 0;
        for (int i = 0; i < grades_array.Length; i++)
        {
            total_score = total_score + grades_array[i];
        }
        Console.WriteLine($"Total Score: {total_score}");
        float average_score = total_score / grades_array.Length;
        Console.WriteLine($"Average Score: {average_score:F2}");
    }
}