using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Employee
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MusicShop; Integrated Security = True";

        public bool GetEmployeeExistence(string login)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Login from [Employee] WHERE Login = '{login}'", conn);
                string log = (string)cmd.ExecuteScalar();
                conn.Close();
                if (log == null) return true;
                else return false;
            }
        }

        public void Add(string surname, string name, string lastname, string post, string login, string password)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO [Employee] (Surname, Name, LastName, Post, Login, Password) VALUES (N'{surname}', N'{name}', N'{lastname}', N'{post}', '{login}', '{password}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
