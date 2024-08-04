using System;
using System.Windows.Forms;

namespace GymManagementSystem.Views
{
    public partial class FitnessClassManagementForm : Form
    {
        public FitnessClassManagementForm()
        {
            InitializeComponent();
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            try
            {
                string className = classNameTextBox.Text;
                string instructor = instructorTextBox.Text;
                DateTime startTime = startTimePicker.Value;
                DateTime endTime = endTimePicker.Value;

                if (string.IsNullOrWhiteSpace(className) || string.IsNullOrWhiteSpace(instructor))
                {
                    throw new ArgumentException("Class Name and Instructor are required fields.");
                }

                // Here you would add the class to a database or list.
                MessageBox.Show($"Class {className} added successfully!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
