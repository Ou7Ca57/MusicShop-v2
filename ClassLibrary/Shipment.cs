using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Shipment
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MusicShop; Integrated Security = True";
        public void AddShipment(int item, int count, int provider)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO [Shipment] (Provider, Item, Count, Status) VALUES ('{provider}', '{item}', '{count}', N'{"Заявка"}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
