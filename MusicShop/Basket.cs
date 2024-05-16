using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class Basket : Form
    {
        int Client;
        public Basket(int ID_Client)
        {
            Client = ID_Client;
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicShopDataSet);

        }

        private void Basket_Load(object sender, EventArgs e)
        {
            this.orderTableAdapter.Fill(this.musicShopDataSet.Order);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in orderDataGridView.SelectedRows)
            {
                DialogResult res = MessageBox.Show("Вы действительно хотите удалить товар из корзины?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    int ID_Order = Convert.ToInt32(row.Cells[0].Value);
                    ClassLibrary.Basket basket = new ClassLibrary.Basket();
                    basket.DeleteItem(ID_Order);
                    orderDataGridView.Rows.RemoveAt(row.Index);
                    MessageBox.Show("Товар удален!", "Внимание!", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            ClassLibrary.Basket basket = new ClassLibrary.Basket();
            for (int i = 0; i < orderDataGridView.Rows.Count; i++)
            {
                int order = Convert.ToInt32(orderDataGridView[0, i].Value);
                int item = Convert.ToInt32(orderDataGridView[1, i].Value);
                int count = Convert.ToInt32(orderDataGridView[4, i].Value);
                int count_before = basket.CheckCount(item);
                if (count_before - count >= 0)
                {
                    basket.UpdateCount(item, count_before - count);
                    basket.PayOrder(order, Client);
                }
                else
                {
                    continue;
                }
            }
            this.orderTableAdapter.Fill(this.musicShopDataSet.Order);
        }
    }
}
