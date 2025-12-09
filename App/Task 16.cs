/* Write a function that asks the  user to input  their age. Depending on their age, output the relevant 
message. Screenshot the  program working with an input age of 23. 
1-15 “You are too young to drive” 
16 “You can drive from this year” 
17-65 “You are old enough to drive” 
66-75 “You need to renew your licence periodically” 
Over 75 “You need to renew your licence annually” */

public static class Task16
{
    public static void Run()
    {
        int age = -1;
        while (age == -1)
        {
            Console.Write("Age: ");
            string? age_input = Console.ReadLine();

            int.TryParse(age_input, out age);

            if (age == -1 || age > 120)
            {
                Console.WriteLine("That Is An Invalid Age");
            }
            else if (age <= 15)
            {
                Console.WriteLine("You Are Too young To Drive");
            }
            else if (age == 16)
            {
                Console.WriteLine("You Can Drive From This Year");
            }
            else if (age <= 65)
            {
                Console.WriteLine("You Need To Renew Your Licence Periodically");
            }
            else
            {
                Console.WriteLine("You Need To Renew Your Licence Annually");
            }
        }
    }
}