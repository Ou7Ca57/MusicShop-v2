using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Auth
    {
        // Строка подключения к базе данных
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MusicShop; Integrated Security = True";

        // Функция проверки корректности ввода логина и пароля
        public (string, string, object) Authorization(string login, string password)
        {
            object IDclient;
            object IDemployee;
            string post;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmdClient = new SqlCommand($"SELECT ID_Client from [Client] WHERE Email='{login}' AND Password='{password}'", conn);
                IDclient = (object)cmdClient.ExecuteScalar();
                SqlCommand cmdEmp = new SqlCommand($"SELECT ID_Employee from [Employee] WHERE Login='{login}' AND Password='{password}'", conn);
                IDemployee = (object)cmdEmp.ExecuteScalar();

                if (IDclient != null)
                {
                    conn.Close();
                    var user = (role: "Client", post: "false", id: IDclient);
                    return user;
                }
                else if (IDemployee != null)
                {
                    SqlCommand cmdPost = new SqlCommand($"SELECT Post from [Employee] WHERE ID_Employee='{IDemployee}'", conn);
                    post = cmdPost.ExecuteScalar().ToString();
                    conn.Close();
                    var user = (role: "Employee", post: post, id: IDemployee);
                    return user;
                }
                else
                {
                    conn.Close();
                    var user = (role: "false", post: "false", id: false);
                    return user;
                }

            }
        }
    }
}
