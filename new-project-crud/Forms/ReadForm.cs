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
    public partial class ReadForm : Form
    {
        public ReadForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "List of Users";
            this.Width = 500;
            this.Height = 400;

            ListBox listBox = new()
            {
                Top = 30,
                Left = 20,
                Width = 440,
                Height = 300
            };

            var users = UserRepository.GetAll();

            foreach (User user in users)
            {
                listBox.Items.Add($"ID: {user.Id} | Name: {user.Name} | Email: {user.Email}");
            }

            Button closeBtn = new() { Text = "Close", Top = 340, Left = 200, Width = 100 };
            closeBtn.Click += (s, e) => this.Close();

            Controls.Add(listBox);
            Controls.Add(closeBtn);
        }
    }
}
