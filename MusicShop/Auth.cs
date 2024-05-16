using MusicShop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MusicShop
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            ClassLibrary.Auth auth = new ClassLibrary.Auth();

            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (login == "" || password == "")
            {
                MessageBox.Show("Пожалуйста, введите логин и/или пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var (role, post, id) = auth.Authorization(login, password);
                if (role != "false")
                {
                    if (role == "Employee" & post == "Администратор")
                    {
                        this.Hide();
                        EmployeeForm window = new EmployeeForm(Convert.ToInt32(id));
                        window.Show();
                    }
                    else if (role == "Client")
                    {
                        this.Hide();
                        ClientForm window = new ClientForm(Convert.ToInt32(id));
                        window.Show();
                    }
                    else
                    {
                        MessageBox.Show("Нет доступа к приложению!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                buttonPassword.BackgroundImage = Resources.eye;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                buttonPassword.BackgroundImage = Resources.Eyeclose;
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
