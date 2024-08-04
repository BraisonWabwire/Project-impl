using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GymManagementSystem.Views
{
    public partial class DisplayEquipmentForm : Form
    {
        private string connectionString = "Server=localhost;Database=gym_management;User ID=root;Password=@Wabwire7627;";
        private DataTable equipmentTable;

        public DisplayEquipmentForm()
        {
            InitializeComponent();
            LoadEquipmentData();
        }

        private void LoadEquipmentData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM equipment";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                    equipmentTable = new DataTable();
                    adapter.Fill(equipmentTable);

                    equipmentDataGridView.DataSource = equipmentTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
        }

        private void deleteEquipmentButton_Click(object sender, EventArgs e)
        {
            if (equipmentDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in equipmentDataGridView.SelectedRows)
                {
                    int equipmentId = Convert.ToInt32(row.Cells["ID"].Value);
                    DeleteEquipment(equipmentId);
                }
                LoadEquipmentData(); // Refresh data after deletion
            }
            else
            {
                MessageBox.Show("Please select an equipment to delete.");
            }
        }

        private void DeleteEquipment(int equipmentId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM equipment WHERE ID = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", equipmentId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting equipment: {ex.Message}");
                }
            }
        }
    }
}
