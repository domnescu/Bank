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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }
        private void CheckLogin(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.LoginIsFree(LoginTextBox.Text) == false)
            {
                LoginExists.Text = "Данный логин занят другим пользователем";
                EndRegButton.Enabled = false;
            } else
            {
                LoginExists.Text = "";
                EndRegButton.Enabled = true;
            }
        }
        private void EndRegButton_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            bool register = db.Register(LoginTextBox.Text, PasswordTextBox.Text, FNameTextbox.Text, LNameTextBox.Text);
            if (register)
            {
                Close();
            } else
            {
                LoginExists.Text = "Ошибка регистрации!";
            }
            
        }
    }
}
