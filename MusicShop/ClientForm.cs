using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class ClientForm : Form
    {
        int Client;
        public ClientForm(int ID_Client)
        {
            Client = ID_Client;
            InitializeComponent();
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicShopDataSet);

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "musicShopDataSet.Item". При необходимости она может быть перемещена или удалена.
            this.itemTableAdapter.Fill(this.musicShopDataSet.Item);
            LoadInfo();

        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Auth window = new Auth();
            window.Show();
        }

        private void buttonBasket_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket(Client);
            basket.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.itemBindingSource.MoveNext();
            LoadInfo();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            this.itemBindingSource.MovePrevious();
            LoadInfo();
        }

        private void LoadInfo()
        {
            String[] words = this.costLabel1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 1)
            {
                string text = this.costLabel1.Text += " руб.";
                this.costLabel1.Text = text;
            }

            string pic = this.photoLabel1.Text;
            if (photoLabel1.Text == "")
            {
                pictureBoxItem.Image = Properties.Resources.errorPhoto;
            }
            else
            {
                try
                {
                    pictureBoxItem.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\items\\" + pic);
                }
                catch
                {
                    pictureBoxItem.Image = Properties.Resources.errorPhoto;
                }
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            ClassLibrary.ClientForm client = new ClassLibrary.ClientForm();
            int item = Convert.ToInt32(iD_ItemLabel1.Text);
            int count = Convert.ToInt32(numericUpDown1.Value);
            client.InsertToBasket(item, count, Client);
        }
    }
}
