using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Rohit", Age = 21, Marks = 90 },
            new Student { Name = "Amit", Age = 20, Marks = 95 },
        };

        var sortedStudents = students
            .OrderByDescending(s => s.Marks)
            .ThenBy(s => s.Age)  
            .ToList();

        foreach (var s in sortedStudents)
        {
            Console.WriteLine($"{s.Name} - Marks: {s.Marks}, Age: {s.Age}");
        }
    }
}
