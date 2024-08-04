using System;
using System.Windows.Forms;

namespace GymManagementSystem.Views
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }

        private void memberManagementButton_Click(object sender, EventArgs e)
        {
            MemberManagementForm memberForm = new MemberManagementForm();
            memberForm.Show();
        }

        private void paymentManagementButton_Click(object sender, EventArgs e)
        {
            MembershipPaymentForm paymentForm = new MembershipPaymentForm();
            paymentForm.Show();
        }

        private void staffManagementButton_Click(object sender, EventArgs e)
        {
            StaffManagementForm staffForm = new StaffManagementForm();
            staffForm.Show();
        }

        private void equipmentManagementButton_Click(object sender, EventArgs e)
        {
            EquipmentManagementForm equipmentForm = new EquipmentManagementForm();
            equipmentForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
