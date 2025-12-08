/* Write a function to read in two numbers and print  their sum and average. 
Run your function to show  that it works with  the numbers  12 and 15. */

public static class Task5
{
    public static void Run()
    {
        int index = 0;
        List<float> numbers = new List<float>();
        string? user_input = "";
        while (user_input != "Exit")
        {
            Console.Write($"Number {index + 1}: ");
            user_input = Console.ReadLine();

            if (user_input != null && user_input != "Exit")
            {
                float number = float.Parse(user_input);
                numbers.Add(number);
            }

            index++;
        }

        float sum = 0;
        float[] numbers_array = numbers.ToArray();
        for (int i = 0; i < numbers_array.Length; i++)
        {
            sum = sum + numbers_array[i];
        }
        Console.WriteLine($"Sum: {sum}");

        float average = sum / numbers_array.Length;
        Console.WriteLine($"Mean: {average}");
    }
}