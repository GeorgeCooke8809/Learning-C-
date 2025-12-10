/* Write a function that generates a random number between 1 and 100 and then  asks the user to guess it. 
Allow them 5 guesses before the game is “lost”. Help them by displaying whether the guess is too high or 
too low after each attempt. Make sure that if they guess correctly that they WIN! */

public static class Task22
{
    public static void Run()
    {
        Random roll = new Random();
        int number = roll.Next(1, 101);

        bool won = false;

        for (int i = 0; i < 5; i++)
        {
            if (!won)
            {
                int guess_int = -0;

                Console.Write($"Guess {i+1}: ");
                string? guess = Console.ReadLine();
                int.TryParse(guess, out guess_int);

                if (guess_int == number) // TODO: Why bad?
                {
                    won = true;
                    Console.WriteLine("That is correct!");
                }
                else if (guess_int > number)
                {
                    Console.WriteLine("Your number is too high.");
                }
                else
                {
                    Console.WriteLine("Your Number is too low.");
                }
            }
        }
    }
}