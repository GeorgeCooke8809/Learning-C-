// Write a function that uses an endless “while loop” that displays the numbers from 5 onwards.

public static class Task21
{
    public static void Run()
    {
        int number = 5;

        while (true)
        {
            Console.WriteLine(number);

            number++;
        }
    }
}