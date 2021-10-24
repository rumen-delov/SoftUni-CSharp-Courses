using Microsoft.Data.SqlClient;
using System;

namespace AdoDotNetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection string: 
            // Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;

            SqlConnection dbCon = new SqlConnection(
                @"Server=.\SQLEXPRESS;
                  Database=SoftUni;
                  Integrated Security=true"); // for Windows authentication (like in the Microsoft SQL Server Management Studio)

            dbCon.Open();

            using (dbCon)
            {
                // Use the connection to execute SQL commands here

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Employees", dbCon);
                using (cmd)
                {
                    int result = (int)cmd.ExecuteScalar();

                    Console.WriteLine(result);
                }

            }
        }
    }
}
