using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GymManagementSystem.Views
{
    public partial class MemberListForm : Form
    {
        private string connectionString = "Server=localhost;Database=gym_management;User ID=root;Password=@Wabwire7627;";

        public MemberListForm()
        {
            InitializeComponent();
            LoadMemberData();
        }

        private void LoadMemberData()
        {
            string query = "SELECT id, Name, Address, PhoneNumber, MemberID, MembershipType FROM members";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    membersDataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading member data: {ex.Message}");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (membersDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = membersDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = membersDataGridView.Rows[selectedRowIndex];
                int memberId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                string query = "DELETE FROM members WHERE id = @MemberId";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MemberId", memberId);
                        cmd.ExecuteNonQuery();
                        LoadMemberData(); // Refresh the list
                        MessageBox.Show("Member deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the member: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a member to delete.");
            }
        }
    }
}
