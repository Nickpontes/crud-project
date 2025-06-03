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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Update User";
            this.Width = 400;
            this.Height = 350;

            Label idLabel = new() { Text = "User ID", Top = 30, Left = 50 };
            TextBox idText = new() { Top = 50, Left = 50, Width = 280 };

            Label nameLabel = new() { Text = "New Name", Top = 90, Left = 50 };
            TextBox nameText = new() { Top = 110, Left = 50, Width = 280 };

            Label emailLabel = new() { Text = "New Email", Top = 150, Left = 50 };
            TextBox emailText = new() { Top = 170, Left = 50, Width = 280 };

            Label passLabel = new() { Text = "New Password", Top = 210, Left = 50 };
            TextBox passText = new() { Top = 230, Left = 50, Width = 280 };

            Button updateBtn = new() { Text = "Update", Top = 270, Left = 150 };
            updateBtn.Click += (s, e) =>
            {
                if (int.TryParse(idText.Text, out int id))
                {
                    var user = new User { Id = id, Name = nameText.Text, Email = emailText.Text, Password = passText.Text };
                    bool updated = UserRepository.Update(user);
                    MessageBox.Show(updated ? "User updated!" : "User not found!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid ID");
                }
            };

            Controls.Add(idLabel);
            Controls.Add(idText);
            Controls.Add(nameLabel);
            Controls.Add(nameText);
            Controls.Add(emailLabel);
            Controls.Add(emailText);
            Controls.Add(passLabel);
            Controls.Add(passText);
            Controls.Add(updateBtn);
        }
    }
}
