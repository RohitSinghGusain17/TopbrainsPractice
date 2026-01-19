public class Program
{
    /// <summary>
    /// Function for sum of digits
    /// </summary>
    /// <param name="x">input</param>
    /// <returns>sum of digits</returns>
    public static int SumOfDigits(int x)
    {
        int sum=0;
        while (x > 0)
        {
            int d=x%10;
            sum+=d;
            x=x/10;
        }
        return sum;
    }

    /// <summary>
    /// Main function
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        int m,n;
        m=int.Parse(Console.ReadLine()!);
        n=int.Parse(Console.ReadLine()!);

        int count = 0;
        for(int i = m; i <= n; i++)//loop to check lucky numbers
        {
            int first = SumOfDigits(i);
            int second = SumOfDigits(i*i);
            if (first * first == second)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}