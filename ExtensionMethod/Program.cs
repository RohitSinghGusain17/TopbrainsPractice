using System;
using System.Collections.Generic;

public static class Extensions
{
    public static string[] DistinctById(this string[] items)
    {
        HashSet<string> seenIds = new HashSet<string>();
        List<string> result = new List<string>();

        foreach (var item in items)
        {
            if (string.IsNullOrEmpty(item))
                continue;

            string[] parts = item.Split(':');

            if (parts.Length != 2)
                continue;

            string id = parts[0];
            string name = parts[1];

            if (seenIds.Add(id))
            {
                result.Add(name);
            }
        }

        return result.ToArray();
    }
}

public class Program
{
    public static void Main()
    {
        string[] items =
        {
            "1:Alice",
            "2:Bob",
            "1:Charlie",
            "3:David",
            "2:Eve"
        };

        string[] distinctNames = items.DistinctById();

        Console.WriteLine(string.Join(", ", distinctNames));
    }
}