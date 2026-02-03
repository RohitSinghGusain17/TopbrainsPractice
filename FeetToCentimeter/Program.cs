using System;

public class Program
{
    public static double FeetToCentimeters(int feet)
    {
        double cm = feet * 30.48;
        return Math.Round(cm, 2, MidpointRounding.AwayFromZero);
    }

    public static void Main()
    {
        int feet = 5;
        double result = FeetToCentimeters(feet);
        Console.WriteLine(result); // 152.40
    }
}
