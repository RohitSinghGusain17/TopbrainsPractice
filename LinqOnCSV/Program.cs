public class Program
{
    public static void Main()
    {
        List<string> csvData = new List<string>
        {
            "Ravi,87",
            "Kumar,98",
            "Arun,92"
        };

        var top3 = csvData.Select(line=>{ var parts = line.Split(",");
            return new
            {
                Name = parts[0],
                Marks = int.Parse(parts[1])
            };
        }).OrderByDescending(x=>x.Marks).Take(3).Select(x=>x.Name).ToList();

        foreach(var i in top3)
        {
            Console.WriteLine(i);
        }


    }
}