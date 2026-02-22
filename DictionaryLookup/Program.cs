using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<int, int> salaries = new Dictionary<int, int>()
        {
            {1, 20000},
            {4, 40000},
            {5, 15000}
        };

        int[] ids = {1, 4, 5};

        int totalSalary = GetTotalSalary(ids, salaries);

        Console.WriteLine("Total Salary: " + totalSalary);
    }

    public static int GetTotalSalary(int[] ids, Dictionary<int, int> salaries)
    {
        int sum = 0;

        foreach (int id in ids)
        {
            if (salaries.ContainsKey(id))
            {
                sum += salaries[id];
            }
        }

        return sum;
    }
}