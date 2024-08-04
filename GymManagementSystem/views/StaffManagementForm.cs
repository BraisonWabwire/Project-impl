using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GymManagementSystem.Views
{
    public partial class StaffManagementForm : Form
    {
        private string connectionString = "Server=localhost;Database=gym_management;User ID=root;Password=@Wabwire7627;";

        public StaffManagementForm()
        {
            InitializeComponent();
            CreateStaffTableIfNotExists();
        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string address = addressTextBox.Text;
                string phoneNumber = phoneTextBox.Text;
                string staffID = staffIDTextBox.Text;
                string role = roleTextBox.Text;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
                {
                    throw new ArgumentException("Name and Address are required fields.");
                }

                // Insert staff into database
                AddStaffToDatabase(name, address, phoneNumber, staffID, role);

                MessageBox.Show($"Staff {name} added successfully!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void AddStaffToDatabase(string name, string address, string phoneNumber, string staffID, string role)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    
                    string query = "INSERT INTO staff (Name, Address, PhoneNumber, StaffID, Role) VALUES (@Name, @Address, @PhoneNumber, @StaffID, @Role)";
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@StaffID", staffID);
                        cmd.Parameters.AddWithValue("@Role", role);
                        
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
            }
        }

        private void CreateStaffTableIfNotExists()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    
                    string query = @"
                        CREATE TABLE IF NOT EXISTS staff (
                            ID INT AUTO_INCREMENT PRIMARY KEY,
                            Name VARCHAR(100) NOT NULL,
                            Address VARCHAR(255) NOT NULL,
                            PhoneNumber VARCHAR(20),
                            StaffID VARCHAR(50) UNIQUE,
                            Role VARCHAR(100)
                        );";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating table: {ex.Message}");
                }
            }
        }

        private void showStaffButton_Click(object sender, EventArgs e)
        {
            DisplayStaffForm displayStaffForm = new DisplayStaffForm();
            displayStaffForm.Show();
        }
    }
}
