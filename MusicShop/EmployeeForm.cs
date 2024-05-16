using ClassLibrary;
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
    public partial class EmployeeForm : Form
    {
        int Employee;
        int cell;
        string cell_item;
        int cell_count;

        public EmployeeForm(int ID_Emplyee)
        {
            Employee = ID_Emplyee;
            InitializeComponent();
        }

        public void EmployeeForm_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.musicShopDataSet.Employee);
            this.shipmentTableAdapter.Fill(this.musicShopDataSet.Shipment);
            this.itemTableAdapter.Fill(this.musicShopDataSet.Item);
            this.orderTableAdapter.Fill(this.musicShopDataSet.Order);
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ClassLibrary.EmployeeForm employee = new ClassLibrary.EmployeeForm();
            if (cell != 0)
            {
                employee.UpdateStatus(cell, Employee, cell_item);
            }
            this.orderTableAdapter.Fill(this.musicShopDataSet.Order);
        }

        private void orderDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cell = Convert.ToInt32(orderDataGridView.Rows[e.RowIndex].Cells[0].Value);
            object temp = orderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            cell_item = temp.ToString();
        }
        private void itemDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cell = Convert.ToInt32(orderDataGridView.Rows[e.RowIndex].Cells[0].Value);
            cell_count = Convert.ToInt32(orderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }

        private void toolStripButtonItemAdd_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.Owner = this;
            addItem.ShowDialog();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in itemDataGridView.SelectedRows)
            {
                DialogResult res = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(row.Cells[0].Value);
                    ClassLibrary.EmployeeForm employee = new ClassLibrary.EmployeeForm();
                    if (employee.DeleteItem(ID) == false)
                    {
                        MessageBox.Show("Товар состоит в заказе!", "Внимание!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        employee.DeleteItem(ID);
                        MessageBox.Show("Товар удален!", "Внимание!", MessageBoxButtons.OK);
                    }
                }
            }
            this.itemTableAdapter.Fill(this.musicShopDataSet.Item);
        }

        private void toolStripButtonEmpDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in employeeDataGridView.SelectedRows)
            {
                DialogResult res = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(row.Cells[0].Value);
                    ClassLibrary.EmployeeForm employee = new ClassLibrary.EmployeeForm();
                    if (ID != Employee)
                    {
                        for (int i = 0; i < orderDataGridView.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(orderDataGridView[4, i].Value) == ID)
                            {
                                int order = Convert.ToInt32(orderDataGridView[0, i].Value);
                                employee.UpdateEmployee(order, Employee);
                            }
                        }
                        employee.DeleteEmployee(ID);
                        MessageBox.Show("Сотрудник удален!", "Внимание!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете удалить самого себя!", "Внимание!", MessageBoxButtons.OK);
                    }
                }
            }
            this.employeeTableAdapter.Fill(this.musicShopDataSet.Employee);
            this.orderTableAdapter.Fill(this.musicShopDataSet.Order);
        }

        private void toolStripButtonItemSave_Click(object sender, EventArgs e)
        {
            ClassLibrary.EmployeeForm employee = new ClassLibrary.EmployeeForm();
            if (cell != 0)
            {
                employee.UpdateCount(cell, cell_count);
                this.itemTableAdapter.Fill(this.musicShopDataSet.Item);
            }
        }

        private void toolStripButtonEmpAdd_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Owner = this;
            addEmployee.ShowDialog();
        }

        private void toolStripButtonShipAdd_Click(object sender, EventArgs e)
        {
            AddShipment addShipment = new AddShipment();
            addShipment.Owner = this;
            addShipment.ShowDialog();
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
        }
    }
}
