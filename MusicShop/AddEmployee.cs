using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MusicShop
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string surname = textBoxSurname.Text;
            string name = textBoxName.Text;
            string lastname = textBoxLastName.Text;
            string post = comboBoxPost.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            ClassLibrary.Employee employee = new ClassLibrary.Employee();
            if (surname == "" || name == "" || lastname == "" || post == "" || login == "" || password == "")
            {
                MessageBox.Show("Пожалуйста, введите все данные!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (employee.GetEmployeeExistence(login) == true)
                {
                    employee.Add(surname, name, lastname, post, login, password);
                    MessageBox.Show("Сотрудник добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmployeeForm main = this.Owner as EmployeeForm;
                    main.EmployeeForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Такой пользователь уже существует!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
