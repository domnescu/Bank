using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.ShowDialog();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.Authorize(LoginTextBox.Text, PasswordTextBox.Text))
            {
                Account account = new Account();
                account.Show();
                account.Login = LoginTextBox.Text;
                Hide();
            } else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
