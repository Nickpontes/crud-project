using new_project_crud.Repositories;
using new_project_crud.Models;
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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Create User";
            this.Width = 400;
            this.Height = 300;

            Label nameLabel = new() { Text = "Name", Top = 30, Left = 50 };
            TextBox nameText = new() { Top = 50, Left = 50, Width = 280 };

            Label emailLabel = new() { Text = "Email", Top = 90, Left = 50 };
            TextBox emailText = new() { Top = 110, Left = 50, Width = 280 };

            Label passLabel = new() { Text = "Password", Top = 150, Left = 50 };
            TextBox passText = new() { Top = 170, Left = 50, Width = 280 };

            Button saveBtn = new() { Text = "Save", Top = 210, Left = 150 };
            saveBtn.Click += (s, e) =>
            {
                UserRepository.Add(new User { Name = nameText.Text, Email = emailText.Text, Password = passText.Text });
                MessageBox.Show("User created!");
                this.Close();
            };

            Controls.Add(nameLabel);
            Controls.Add(nameText);
            Controls.Add(emailLabel);
            Controls.Add(emailText);
            Controls.Add(passLabel);
            Controls.Add(passText);
            Controls.Add(saveBtn);
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
