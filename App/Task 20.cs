/* Write a function that uses a “while loop” to ask the user to type in numbers until they enter the number 
999. Display the  number of numbers entered,  their sum and mean (excluding the final 999). Demonstrate it 
working with the  number sequence:  15,23,4,99,12,57,21,999. */

public static class Task20
{
    public static void Run()
    {
        int number = -1;
        List<int> numbers = new List<int>();
        
        while (number != 999)
        {
            if (number != -1 && number != 999)
            {
                numbers.Add(number);
            }

            Console.Write("Number: ");
            string? number_input = Console.ReadLine();

            if (!int.TryParse(number_input, out number))
            {
                number = -1;
            }
        }

        int[] numbers_array = numbers.ToArray();

        Console.WriteLine($"Total Numbers: {numbers_array.Length}");

        float total = 0;
        for (int i = 0; i < numbers_array.Length; i++)
        {
            total = total + numbers_array[i];
        }

        Console.WriteLine($"Sum: {total}\nMean: {total / numbers_array.Length}");
    }
}