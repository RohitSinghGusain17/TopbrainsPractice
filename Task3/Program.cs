using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    /// <summary>
    /// Function to swap two numbers using ref
    /// </summary>
    public static void SwapWithRef(ref int a, ref int b)
    {
        a=a+b;
        b=a-b;
        a=a-b;
    }

    /// <summary>
    /// Function to swap two numbers using out
    /// </summary>
    public static void SwapWithOut(ref int m, ref int n, out int x, out int y)
    {
        m=m+n;
        y=m-n;
        x=m-y;
    }
    public static void Main(string[] args)
    {
        int a=6;
        int b=2;
        SwapWithRef(ref a, ref b);//method ref calling
        Console.WriteLine(a+" "+b);
        int m=4;
        int n=3;
        SwapWithOut(ref m, ref n, out int x, out int y); //method out calling
        Console.WriteLine(x+" "+y);
    }
}