using System;
using System.Linq;

public class Program
{
    public static double? CalculateAverage(double?[] values)
    {
        double sum = 0;
        int count = 0;

        foreach (var v in values)
        {
            if (v.HasValue)
            {
                sum += v.Value;
                count++;
            }
        }

        if (count == 0)
            return null;

        double avg = sum / count;
        return Math.Round(avg, 2, MidpointRounding.AwayFromZero);
    }
   
    public static void Main()
    {
        double?[] values = { 10.555, null, 20.444, null, 30.111 };

        double? result = CalculateAverage(values);

        Console.WriteLine(result); // 20.37
    }
}
