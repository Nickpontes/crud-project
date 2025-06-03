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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Dashboard";
            this.Width = 400;
            this.Height = 300;

            Button createBtn = new() { Text = "Create", Top = 30, Left = 150, Width = 100 };
            Button readBtn = new() { Text = "Read", Top = 70, Left = 150, Width = 100 };
            Button updateBtn = new() { Text = "Update", Top = 110, Left = 150, Width = 100 };
            Button deleteBtn = new() { Text = "Delete", Top = 150, Left = 150, Width = 100 };
            Button backBtn = new() { Text = "Back", Top = 190, Left = 150, Width = 100 };

            createBtn.Click += (s, e) => new CreateForm().Show();
            readBtn.Click += (s, e) => new ReadForm().Show();
            updateBtn.Click += (s, e) => new UpdateForm().Show();
            deleteBtn.Click += (s, e) => new DeleteForm().Show();
            backBtn.Click += (s, e) => { new MainForm().Show(); this.Hide(); };

            Controls.Add(createBtn);
            Controls.Add(readBtn);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(backBtn);
        }
    }
}
