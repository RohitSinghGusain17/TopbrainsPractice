using System;
using Microsoft.Data.SqlClient;

public class Program
{
    public static void Main()
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Database=StudentDatabase;Trusted_Connection=True;TrustServerCertificate=True";

        Console.Write("Enter Id: ");
        int id = int.Parse(Console.ReadLine()!);
        Console.Write("Enter Name: ");
        string name = Console.ReadLine()!;
        Console.Write("Enter Marks: ");
        int marks = int.Parse(Console.ReadLine()!);

        string query = "INSERT INTO Students (Id, Name, Marks) VALUES (@Id, @Name, @Marks)";

        using (var con = new SqlConnection(connectionString))
        {
            con.Open();

            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Marks", marks);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Inserted Successfully");
            }
        }
    }
}