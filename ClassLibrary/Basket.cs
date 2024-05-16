using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Basket
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MusicShop; Integrated Security = True";

        public void DeleteItem(int ID_Order)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM [Order] WHERE ID_Order='{ID_Order}'", conn);
                cmd.ExecuteScalar();
                conn.Close();
            }
        }

        public void PayOrder(int Order, int Client)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string status = "Оплачен";
                SqlCommand cmd = new SqlCommand($"UPDATE [Order] SET Status = N'{status}' WHERE Client='{Client}' AND ID_Order='{Order}' AND Status=N'{"Не оплачен"}'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdateCount(int item, int count)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand($"UPDATE [Item] SET Count = '{count}' WHERE ID_item='{item}'", conn);
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
        }
        public int CheckCount(int item)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Count from [Item] WHERE ID_Item='{item}'", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
        }
    }
}
