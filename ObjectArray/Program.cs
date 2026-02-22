using System;

public class Program
{
    public static void Main()
    {
        object[] values = { 10, "hello", true, 5, null, 20, 3.14, false };

        int sum = SumIntegers(values);

        Console.WriteLine("Sum of integers: " + sum);
    }

    public static int SumIntegers(object[] values)
    {
        int sum = 0;

        foreach (var v in values)
        {
            if (v is int x)   // Pattern matching
            {
                sum += x;
            }
        }

        return sum;
    }
}