using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Item
    {
        public void NewItem(string name, string type, decimal cost, string photo)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MusicShop; Integrated Security = True"))
            {
                conn.Open();
                int count = 0;
                SqlCommand cmd = new SqlCommand($"INSERT INTO [Item] (ItemName, ItemType, Photo, Cost, Count) VALUES ('{name}', '{type}', '{photo}', '{cost}', '{count}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
