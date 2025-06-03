using new_project_crud.Forms;
using new_project_crud;
using System;
using System.Windows.Forms;

namespace new_project_crud
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}