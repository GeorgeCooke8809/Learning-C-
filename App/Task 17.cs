/* For your AS-Level Computing, you  will sit two exams: 
COMP1 – 60% of AS (2 hour on-screen exam) 100 marks 
COMP2 – 40% of AS (1 hour written exam) 60 marks  

Write a function to read in the marks achieved for each paper and output the total score, percentage and 
grade (>=80% A, 70-79% B, 60-69% C, 50-59% D, 40-49% E, <40% U)  

Extension task: 
Make it work for the A-level grade (COMP1 and COMP2 are 30% and 20% of A2 respectively) 
COMP3 – 30% of A2 (2 hour 30 minutes written exam) 100 marks 
COMP4 – 20% of A2 (The Computing Project) 75 marks */

public static class Task17
{
    public static void Run()
    {
        float[] min_boundaries = [0, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f];
        string[] grades = ["U", "E", "D", "C", "B", "A"];

        int[] max_marks = [100, 60, 100, 75];

        int[] marks = new int[4];

        for (int i = 0; i < 4; i++)
        {
            bool passed = false;

            while (!passed)
            {
                int result = 0;
                Console.Write($"Comp {i+1} Mark: ");
                string? user_input = Console.ReadLine();

                int.TryParse(user_input, out result);

                if (result <= max_marks[i])
                {
                    marks[i] = result;
                    
                    passed = true;
                }
                else
                {
                    Console.WriteLine("That is an invalid number of marks.");
                }
            }
        }
        float total_score = 0;

        for(int i = 0; i < 4; i++)
        {
            total_score = total_score + marks[i];
        }

        Console.WriteLine($"\nTotal Score: {total_score}");
        float percentage = total_score / 335;
        string grade = "";

        for (int i = 0; i < min_boundaries.Length; i++)
        {
            if (percentage >= min_boundaries[i])
            {
                grade = grades[i];
            }
        }
        Console.WriteLine($"Percentage: {percentage*100:F2}%\nGrade: {grade}");
    }
}