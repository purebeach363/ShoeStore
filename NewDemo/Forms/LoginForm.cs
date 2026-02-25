using NewDemo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDemo.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            if (checkBoxShowPassword.Checked == false)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            var db = new DB();
            var users = db.GetUsers();
            User loggedUser = null;

            foreach (var user in users)
            {
                if (user.login == login && user.password == password)
                {
                    loggedUser = user;
                    MainForm form = new MainForm(loggedUser);
                    form.Show();
                    this.Hide();
                }
            }
            if (loggedUser == null)
            {
                MessageBox.Show
                    (
                        "Ввод данных был произведен некорректно",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(null);
            form.Show();
            this.Hide();
        }
    }
}
