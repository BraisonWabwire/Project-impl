using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GymManagementSystem.Views
{
    public partial class MemberManagementForm : Form
    {
        private string connectionString = "Server=localhost;Database=gym_management;User ID=root;Password=@Wabwire7627;";

        public MemberManagementForm()
        {
            InitializeComponent();
            CreateMembersTableIfNotExists();
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string address = addressTextBox.Text;
                string phoneNumber = phoneTextBox.Text;
                string memberID = memberIDTextBox.Text;
                string membershipType = membershipTypeComboBox.SelectedItem?.ToString(); // Ensure there's a selected item

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
                {
                    throw new ArgumentException("Name and Address are required fields.");
                }

                // Insert member into database
                AddMemberToDatabase(name, address, phoneNumber, memberID, membershipType);

                MessageBox.Show($"Member {name} added successfully!");
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

        private void AddMemberToDatabase(string name, string address, string phoneNumber, string memberID, string membershipType)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    
                    string query = "INSERT INTO members (Name, Address, PhoneNumber, MemberID, MembershipType) VALUES (@Name, @Address, @PhoneNumber, @MemberID, @MembershipType)";
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.Parameters.AddWithValue("@MembershipType", membershipType);
                        
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
            }
        }

        private void CreateMembersTableIfNotExists()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    
                    string query = @"
                        CREATE TABLE IF NOT EXISTS members (
                            ID INT AUTO_INCREMENT PRIMARY KEY,
                            Name VARCHAR(100) NOT NULL,
                            Address VARCHAR(255) NOT NULL,
                            PhoneNumber VARCHAR(20),
                            MemberID VARCHAR(50) UNIQUE,
                            MembershipType VARCHAR(50)
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

        private void showMembersButton_Click(object sender, EventArgs e)
        {
            MemberListForm memberListForm = new MemberListForm();
            memberListForm.Show();
        }
    }
}
