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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Manter vazio ou adicionar lógica de inicialização se necessário. 
        }

        private void SetupUI()
        {
            this.Text = "Welcome";
            this.Width = 400;
            this.Height = 300;

            Label label = new() { Text = "Welcome to CRUD App", AutoSize = true, Top = 30, Left = 120 };
            Button loginButton = new() { Text = "Login", Top = 80, Left = 150, Width = 100 };
            Button exitButton = new() { Text = "Exit", Top = 130, Left = 150, Width = 100 };

            loginButton.Click += (s, e) => { new LoginForm().Show(); this.Hide(); };
            exitButton.Click += (s, e) => { Application.Exit(); };

            Controls.Add(label);
            Controls.Add(loginButton);
            Controls.Add(exitButton);
        }
    }
}
