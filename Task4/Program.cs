using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json;
/// <summary>
/// Student Record
/// </summary>
/// <param name="name">Name</param>
/// <param name="score">Score</param>
public record Student(string name, int score);
public class Program
{
    public static void Main(string[] args)
    {
        string[] students = new string[5];//array to store student in "Name:Score" format
        students[0]="Test1:59";
        students[1]="Test2:98";
        students[2]="Test5:89";
        students[3]="Test4:53";
        students[4]="Test3:89";

        int minScore=55;

        List<Student> list = new List<Student>(); //List to store student using Student Record
        for(int i=0; i < students.Length; i++)//loop to store student in the list 
        {
            var s = students[i].Split(":");
            list.Add(new Student(s[0],int.Parse(s[1])));
        }

        var result = list.Where(x=>x.score>=minScore).OrderByDescending(x=>x.score).ThenBy(x=>x.name); //Linq query
        var serialize = JsonSerializer.Serialize(result);//Json Serializer
        Console.WriteLine(serialize);
    }
}