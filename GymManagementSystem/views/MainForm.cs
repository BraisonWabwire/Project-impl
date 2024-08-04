using System;
using System.Windows.Forms;

namespace GymManagementSystem.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void memberManagementButton_Click(object sender, EventArgs e)
        {
            var memberForm = new MemberManagementForm();
            memberForm.Show();
        }

        private void staffManagementButton_Click(object sender, EventArgs e)
        {
            var staffForm = new StaffManagementForm();
            staffForm.Show();
        }

        private void fitnessClassManagementButton_Click(object sender, EventArgs e)
        {
            var classForm = new FitnessClassManagementForm();
            classForm.Show();
        }
    }
}
