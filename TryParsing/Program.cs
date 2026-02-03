using System;

public class Program
{
    public static int SumValidIntegers(string[] tokens)
    {
        int sum = 0;

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int value))
            {
                sum += value;
            }
        }

        return sum;
    }

    static void Main()
    {
        string[] tokens = { "10", "20", "abc", "999999999999", "-5", "30" };

        int result = SumValidIntegers(tokens);

        Console.WriteLine(result); // 55
    }
}
