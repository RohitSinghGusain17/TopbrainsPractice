public class Program
{
    public static void Main()
    {
        List<string> products = new List<string> {"Pen","Book","Pen","Pencil","Book"};
        var duplicates = products.GroupBy(x=>x).Where(x=>x.Count()>1).Select(x => x.Key).ToList();

        foreach(var d in duplicates)
        {
            Console.WriteLine(d);
        }
    }
}