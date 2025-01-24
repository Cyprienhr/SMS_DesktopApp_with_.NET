using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseHelper.InitializeDatabase(); // Create the database if it doesn't exist

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
