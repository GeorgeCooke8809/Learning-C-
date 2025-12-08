// Write a function to display your five favorite bands (or food  items) on separate lines

public static class Task2
{
    public static void Run()
    {
        string[] foods = {"Pizza", "Sausage Roll", "Chips", "Burger", "Mozzarella Sticks"};

        for (int i = 0; i < foods.Length; i++)
        {
            Console.WriteLine(foods[i]);
        }
    }
}