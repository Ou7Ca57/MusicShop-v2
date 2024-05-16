using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EmployeeForm
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MusicShop; Integrated Security = True";

        public void UpdateStatus(int Order, int Employee, string status)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE [Order] SET Status = N'{status}', Employee='{Employee}' WHERE ID_Order='{Order}'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void UpdateCount(int Item, int count)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE [Item] SET Count = '{count}' WHERE ID_Item='{Item}'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void UpdateEmployee(int Order, int Employee)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE [Order] SET Employee='{Employee}' WHERE ID_Order='{Order}'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public bool DeleteItem(int Item)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand($"SELECT ID_Order FROM [Order] WHERE Item='{Item}'" , conn);
                int result = Convert.ToInt32(cmd1.ExecuteScalar());
                if (result == 0)
                {
                    SqlCommand cmd2 = new SqlCommand($"DELETE FROM Item WHERE ID_Item='{Item}'", conn);
                    cmd2.ExecuteScalar();
                    conn.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void DeleteEmployee(int Emp)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand($"SELECT Employee FROM [Order] WHERE Employee='{Emp}'", conn);
                int result = Convert.ToInt32(cmd1.ExecuteScalar());
                if (result == 0)
                {
                    SqlCommand cmd2 = new SqlCommand($"DELETE FROM Employee WHERE ID_Employee='{Emp}'", conn);
                    cmd2.ExecuteScalar();
                    conn.Close();
                }
                else
                {

                }
            }
        }
    }
}
