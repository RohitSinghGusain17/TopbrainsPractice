using System;

public class Program
{
    public static void Main()
    {
        double radius = 5.0;

        double area = GetCircleArea(radius);

        Console.WriteLine("Area: " + area);
    }

    public static double GetCircleArea(double radius)
    {
        double area = Math.PI * radius * radius;

        return Math.Round(area, 2, MidpointRounding.AwayFromZero);
    }
}