using System;
using Microsoft.Data.SqlClient;
using System.Data;

public class Program
{
    public static void Main()
    {
        string cs = @"Data Source=.\SQLEXPRESS;Database=StudentDatabase;Trusted_Connection=True;TrustServerCertificate=True";

        using (var con = new SqlConnection(cs))
        {
            using (var cmd = new SqlCommand("GetEmployeeCount", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter outputParam = new SqlParameter("@TotalCount", SqlDbType.Int);
                outputParam.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(outputParam);

                con.Open();
                cmd.ExecuteNonQuery();

                int count = (int)cmd.Parameters["@TotalCount"].Value;
                Console.WriteLine($"Employee Count: {count}");
            }
        }
    }
}