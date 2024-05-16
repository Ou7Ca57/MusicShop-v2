using ClassLibrary;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MusicShop
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = Path.GetFileName(openFileDialog1.FileName);
                this.textBoxPhoto.Text = filename;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClassLibrary.Item item = new ClassLibrary.Item();
            string name = textBoxName.Text;
            string type = textBoxType.Text;
            decimal cost = numericUpDownCost.Value;
            string photo = textBoxPhoto.Text;
            if (textBoxName.Text != "" || textBoxType.Text != "")
            {
                item.NewItem(name, type, cost, photo);
                MessageBox.Show("Товар добавлен!", "Внимание!", MessageBoxButtons.OK);
                EmployeeForm main = this.Owner as EmployeeForm;
                main.EmployeeForm_Load(sender, e);
                this.Close();
            }
            else
            {
                MessageBox.Show("Введены не все данные!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
