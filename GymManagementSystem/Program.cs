using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GymManagementSystem
{
    static class Program
    {
        public static MySqlConnection Connection;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Initialize and open MySQL connection
            string connectionString = "Server=localhost;Database=gym_management;User ID=root;Password=@Wabwire7627;";
            try
            {
                Connection = new MySqlConnection(connectionString);
                Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}");
                return; // Exit application if connection fails
            }
            
            // Run the main form
            Application.Run(new GymManagementSystem.Views.MainPageForm());
        }
    }
}
