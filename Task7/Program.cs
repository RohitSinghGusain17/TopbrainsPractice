public class Program
{
    public static string GetHeightCategory(int heightCm)
    {
        if (heightCm < 150)
            return "Short";
        else if (heightCm < 180)
            return "Average";
        else
            return "Tall";
    }

    public static void Main()
    {
        int heightCm = 170;
        Console.WriteLine(GetHeightCategory(heightCm));
    }
}