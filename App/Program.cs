class Program
{
    static void Main()
    {
        while (true) // Initiates Infinite Loop
        {
            Task13.Run(); // Trigger Task
            Console.ReadKey(); // Wait Before Next Loop
            Console.WriteLine(); // Leave Line Gap
        }
    }
}