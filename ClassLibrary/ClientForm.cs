using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClientForm
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MusicShop; Integrated Security = True";
        public void InsertToBasket(int item, int count, int client)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO [Order] (Item, Count, Client, Status) VALUES ('{item}', '{count}', '{client}', N'{"Не оплачен"}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
