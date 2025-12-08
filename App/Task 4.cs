// Write a function to read in the user’s name and then display a message to welcome them by name (e.g.: “Hello Fred!”)

public static class Task4
{
    public static void Run()
    {
        Console.Write("Name: ");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello {name}.");
    }
}