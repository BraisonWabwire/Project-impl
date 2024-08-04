using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GymManagementSystem.Views
{
    public partial class EquipmentManagementForm : Form
    {
        private string connectionString = "Server=localhost;Database=gym_management;User ID=root;Password=@Wabwire7627;";

        public EquipmentManagementForm()
        {
            InitializeComponent();
            CreateEquipmentTableIfNotExists();
        }

        private void addEquipmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                string equipmentName = equipmentNameTextBox.Text;
                string equipmentID = equipmentIDTextBox.Text;
                string description = descriptionTextBox.Text;

                if (string.IsNullOrWhiteSpace(equipmentName) || string.IsNullOrWhiteSpace(equipmentID))
                {
                    throw new ArgumentException("Equipment Name and Equipment ID are required fields.");
                }

                // Insert equipment into database
                AddEquipmentToDatabase(equipmentName, equipmentID, description);

                MessageBox.Show($"Equipment {equipmentName} added successfully!");
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

        private void AddEquipmentToDatabase(string equipmentName, string equipmentID, string description)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO equipment (EquipmentName, EquipmentID, Description) VALUES (@EquipmentName, @EquipmentID, @Description)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@EquipmentName", equipmentName);
                        cmd.Parameters.AddWithValue("@EquipmentID", equipmentID);
                        cmd.Parameters.AddWithValue("@Description", description);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
            }
        }

        private void CreateEquipmentTableIfNotExists()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                        CREATE TABLE IF NOT EXISTS equipment (
                            ID INT AUTO_INCREMENT PRIMARY KEY,
                            EquipmentName VARCHAR(100) NOT NULL,
                            EquipmentID VARCHAR(50) UNIQUE,
                            Description TEXT
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

        private void showEquipmentButton_Click(object sender, EventArgs e)
        {
            DisplayEquipmentForm displayEquipmentForm = new DisplayEquipmentForm();
            displayEquipmentForm.Show();
        }
    }
}
