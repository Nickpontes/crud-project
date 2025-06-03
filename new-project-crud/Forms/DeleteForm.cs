using new_project_crud.Repositories;
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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Delete User";
            this.Width = 400;
            this.Height = 200;

            Label idLabel = new() { Text = "User ID to delete", Top = 30, Left = 50 };
            TextBox idText = new() { Top = 50, Left = 50, Width = 280 };

            Button deleteBtn = new() { Text = "Delete", Top = 90, Left = 150 };
            deleteBtn.Click += (s, e) =>
            {
                if (int.TryParse(idText.Text, out int id))
                {
                    bool deleted = UserRepository.Delete(id);
                    MessageBox.Show(deleted ? "User deleted!" : "User not found.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid ID");
                }
            };

            Controls.Add(idLabel);
            Controls.Add(idText);
            Controls.Add(deleteBtn);
        }
    }
}
