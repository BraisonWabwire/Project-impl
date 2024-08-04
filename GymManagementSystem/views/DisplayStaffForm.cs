using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GymManagementSystem.Views
{
    public partial class DisplayStaffForm : Form
    {
        private string connectionString = "Server=localhost;Database=gym_management;User ID=root;Password=@Wabwire7627;";

        public DisplayStaffForm()
        {
            InitializeComponent();
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    
                    string query = "SELECT ID, Name, Address, PhoneNumber, StaffID, Role FROM staff";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable staffTable = new DataTable();
                        adapter.Fill(staffTable);
                        staffDataGridView.DataSource = staffTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (staffDataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedRowIndex = staffDataGridView.SelectedCells[0].RowIndex;
                    int staffID = Convert.ToInt32(staffDataGridView.Rows[selectedRowIndex].Cells["ID"].Value);

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        
                        string query = "DELETE FROM staff WHERE ID = @ID";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ID", staffID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Refresh the data grid view
                    LoadStaffData();
                    MessageBox.Show("Staff member deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting staff member: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to delete.");
            }
        }
    }
}
