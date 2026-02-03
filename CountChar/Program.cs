using System;
using System.Collections.Generic;

public class Program
{
    public static void CountCharacters(string input)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        foreach (var item in freq)
        {
            Console.WriteLine($"{item.Key} = {item.Value}");
        }
    }

    public static void Main()
    {
        string str = "hello";
        CountCharacters(str);
    }
}
