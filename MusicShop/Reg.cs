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

namespace MusicShop
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string surname = textBoxSurname.Text;
            string name = textBoxName.Text;
            string lastname = textBoxLastName.Text;
            string email = textBoxEmail.Text;
            string password1 = textBoxPass1.Text;
            string password2 = textBoxPass2.Text;

            ClassLibrary.Reg reg = new ClassLibrary.Reg();
            if (surname == "" || name == "" || lastname == "" || email == "" || password1 == "" || password2 == "")
            {
                MessageBox.Show("Пожалуйста, введите все данные!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password1 != password2)
            {
                MessageBox.Show("Пароли не совпадают!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool resEmail = reg.IsValidEmail(email);
                if (resEmail == false)
                {
                    MessageBox.Show("Неверный формат электронной почты!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool log = reg.GetClientExistence(email);
                    if (log == false)
                    {
                        MessageBox.Show("Такой пользователь уже существует!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        reg.InsertClient(surname, name, lastname, email, password1);
                        MessageBox.Show("Вы зарегистрированы!", "Внимание!", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
            }
        }

        private void buttonPass1_Click(object sender, EventArgs e)
        {
            if (textBoxPass1.UseSystemPasswordChar == true)
            {
                textBoxPass1.UseSystemPasswordChar = false;
                buttonPass1.BackgroundImage = Resources.eye;
            }
            else
            {
                textBoxPass1.UseSystemPasswordChar = true;
                buttonPass1.BackgroundImage = Resources.Eyeclose;
            }
        }

        private void buttonPass2_Click(object sender, EventArgs e)
        {
            if (textBoxPass2.UseSystemPasswordChar == true)
            {
                textBoxPass2.UseSystemPasswordChar = false;
                buttonPass2.BackgroundImage = Resources.eye;
            }
            else
            {
                textBoxPass2.UseSystemPasswordChar = true;
                buttonPass2.BackgroundImage = Resources.Eyeclose;
            }
        }
    }
}
