using new_project_crud.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_project_crud.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Login";
            this.Width = 400;
            this.Height = 250;

            Label emailLabel = new() { Text = "Email", Top = 30, Left = 50 };
            TextBox emailText = new() { Top = 50, Left = 50, Width = 280 };

            Label passLabel = new() { Text = "Password", Top = 90, Left = 50 };
            TextBox passText = new() { Top = 110, Left = 50, Width = 280, PasswordChar = '*' };

            Button loginBtn = new() { Text = "Login", Top = 160, Left = 150 };
            loginBtn.Click += (s, e) =>
            {
                if (Auth.Login(emailText.Text, passText.Text))
                {
                    new DashboardForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login!");
                }
            };

            Controls.Add(emailLabel);
            Controls.Add(emailText);
            Controls.Add(passLabel);
            Controls.Add(passText);
            Controls.Add(loginBtn);
        }
    }
}
