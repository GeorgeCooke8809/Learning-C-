/* Write a function to read in two numbers and print  their product. Run your  function  to show  that  it works 
with  the numbers 12 and 15. */

using System.Globalization;

public static class Task6
{
    public static void Run()
    {
        List<float> numbers = new List<float>();

        for (int i = 0; i < 2; i++)
        {
            float num = 0.0f;
            Console.Write($"Number {i + 1}: ");
            string? choice = Console.ReadLine();

            if (choice != null)
            {
                num = float.Parse(choice);
            }

            numbers.Add(num);
        }
        float product = numbers[0] * numbers[1];
        Console.WriteLine($"Product: {product}");
    }
}