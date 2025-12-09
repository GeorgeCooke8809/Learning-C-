/* Temperatures can be converted from Fahrenheit to Centigrade using the following formula, where F is the 
temperature in Fahrenheit and C the temperature in Centigrade: 
C = 5(F-32) / 9 
Write a function to input a Fahrenheit temperature and output  the equivalent temperature in Centigrade.  
 
Extension: modify the output  to  display the temperature to two  decimal places. */

public static class Task12
{
    public static void Run()
    {
        float fahrenheit = 0;
        Console.Write("Fahrenheit Temp: ");
        string? user_input = Console.ReadLine();

        if (user_input != null)
        {
            fahrenheit = float.Parse(user_input);
        }
        float celsius = ((fahrenheit - 32) * 5)/9;
        Console.WriteLine($"Temperature Celsius: {celsius:F2}");
    }
}