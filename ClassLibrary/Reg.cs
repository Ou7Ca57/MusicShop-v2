using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reg
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MusicShop; Integrated Security = True";
        public bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool GetClientExistence(string email)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Email from [Client] WHERE Email = '{email}'", conn);
                string log = (string)cmd.ExecuteScalar();
                conn.Close();
                if (log == null) return true;
                else return false;
            }
        }

        public void InsertClient(string surname, string name, string last_name, string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO [Client] (Surname, Name, LastName, Email, Password) VALUES ('{surname}', '{name}', '{last_name}', '{email}', '{password}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
