using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Program
{
    public static void Main()
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Database=StudentDatabase;Trusted_Connection=True;TrustServerCertificate=True";
        string query = "SELECT Id, Name, Price FROM Product";

        List<Product> products = new List<Product>();

        using (var con = new SqlConnection(connectionString))
        {

            using (var cmd = new SqlCommand(query, con)){
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetDecimal(2)
                    };

                    products.Add(p);
                }
            }
        }

        foreach (var p in products)
        {
            Console.WriteLine($"{p.Id} {p.Name} {p.Price}");
        }
    }
}