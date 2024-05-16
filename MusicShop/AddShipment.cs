using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class AddShipment : Form
    {
        int item_id;
        int count_text;
        int provider_id;

        public AddShipment()
        {
            InitializeComponent();
        }

        private void AddShipment_Load(object sender, EventArgs e)
        {
            this.providerTableAdapter.Fill(this.musicShopDataSet.Provider);
            this.itemTableAdapter.Fill(this.musicShopDataSet.Item);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string item = comboBoxItem.Text;
            item_id = Convert.ToInt32(comboBoxItem.SelectedValue);
            count_text = Convert.ToInt32(NumCount.Value);
            string provider = comboBoxProvider.Text;
            provider_id = Convert.ToInt32(comboBoxProvider.SelectedValue);
            listBox1.Items.Add("Товар: " + item + $" ({item_id})");
            listBox1.Items.Add("Количество товара: " + count_text);
            listBox1.Items.Add("Поставщик: " + provider + $" ({provider_id})");
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                ClassLibrary.Shipment shipment = new ClassLibrary.Shipment();
                shipment.AddShipment(item_id, count_text, provider_id);
                EmployeeForm main = this.Owner as EmployeeForm;
                main.EmployeeForm_Load(sender, e);
                MessageBox.Show("Заявка отправлена!", "Внимание!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Заявка не сформирована!", "Внимание!", MessageBoxButtons.OK);
            }
        }
    }
}
