using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GymManagementSystem.Views
{
    public partial class MembershipPaymentForm : Form
    {
        private string connectionString = "Server=localhost;Database=gym_management;User ID=root;Password=@Wabwire7627;";

        public MembershipPaymentForm()
        {
            InitializeComponent();
            CreateTablesIfNotExists();
        }

        private void processPaymentButton_Click(object sender, EventArgs e)
        {
            try
            {
                string memberID = memberIDTextBox.Text;
                decimal amount = decimal.Parse(amountTextBox.Text);

                if (string.IsNullOrWhiteSpace(memberID) || amount <= 0)
                {
                    throw new ArgumentException("Member ID and a valid amount are required.");
                }

                // Process payment in the database
                ProcessPayment(memberID, amount);

                MessageBox.Show($"Payment of {amount:C} for Member ID {memberID} processed successfully!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid amount.");
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

        private void ProcessPayment(string memberID, decimal amount)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Example query: Update the member's payment status and balance
                string query = "UPDATE members SET Balance = Balance - @Amount, Paid = 1 WHERE MemberID = @MemberID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@MemberID", memberID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        throw new Exception("Member ID not found or no changes made.");
                    }
                }
            }
        }

        private void CreateTablesIfNotExists()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Create the 'members' table if it doesn't exist
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS members (
                        ID INT AUTO_INCREMENT PRIMARY KEY,
                        Name VARCHAR(100) NOT NULL,
                        Address VARCHAR(255) NOT NULL,
                        PhoneNumber VARCHAR(20),
                        MemberID VARCHAR(50) UNIQUE,
                        Balance DECIMAL(10, 2) DEFAULT 0.00,
                        Paid BOOLEAN DEFAULT FALSE
                    );";

                using (MySqlCommand cmd = new MySqlCommand(createTableQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void showPaidUsersButton_Click(object sender, EventArgs e)
        {
            PaidUsersForm paidUsersForm = new PaidUsersForm();
            paidUsersForm.Show();
        }
    }
}
