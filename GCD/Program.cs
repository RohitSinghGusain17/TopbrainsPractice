using System;

namespace GreatestCommonDivisor
{
public class Program
{
    public static int GCD(int a, int b)
    {
        if (b == 0)
            return a;

        return GCD(b, a % b);
    }

    public static void Main()
    {
        int a = 48;
        int b = 18;

        int result = GCD(a, b);
        Console.WriteLine("GCD: " + result);
    }
}
}