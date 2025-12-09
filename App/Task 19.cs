/* Write a function that uses a “while loop” to ask the user to type in ‘ducky’ and loop endlessly until user 
types it in. Show  it working with the words:  cup, teapot, cake, ducky entered in sequence. */

public static class Task19
{
    public static void Run()
    {
        string? user_input = "";

        while (user_input != "ducky")
        {
            Console.Write("Input: ");
            user_input = Console.ReadLine();
        }
    }
}