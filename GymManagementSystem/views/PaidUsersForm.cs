using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace GymManagementSystem.Views
{
    public partial class PaidUsersForm : Form
    {
        private string connectionString = "Server=localhost;Database=gym_management;User ID=root;Password=@Wabwire7627;";

        public PaidUsersForm()
        {
            InitializeComponent();
            LoadPaidUsers();
        }

        private void LoadPaidUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM members WHERE Paid = 1";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    paidUsersDataGridView.DataSource = dataTable;
                }
            }
        }

        private void generatePdfButton_Click(object sender, EventArgs e)
        {
            if (paidUsersDataGridView.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    FileName = "PaidUsersReport.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (Document doc = new Document())
                        {
                            PdfWriter.GetInstance(doc, fs);
                            doc.Open();

                            // Add title
                            doc.Add(new Paragraph("Paid Users Report"));

                            // Add table
                            PdfPTable table = new PdfPTable(paidUsersDataGridView.Columns.Count);

                            // Add headers
                            foreach (DataGridViewColumn column in paidUsersDataGridView.Columns)
                            {
                                table.AddCell(new Phrase(column.HeaderText));
                            }

                            // Add rows
                            foreach (DataGridViewRow row in paidUsersDataGridView.Rows)
                            {
                                if (row.IsNewRow) continue;
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    table.AddCell(new Phrase(cell.Value?.ToString() ?? string.Empty));
                                }
                            }

                            doc.Add(table);
                            doc.Close();
                        }
                    }

                    MessageBox.Show("PDF report generated successfully!");
                }
            }
            else
            {
                MessageBox.Show("No data available to generate the report.");
            }
        }
    }
}
