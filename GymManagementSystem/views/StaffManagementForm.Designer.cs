namespace GymManagementSystem.Views
{
    partial class StaffManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox staffIDTextBox;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.Button showStaffButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.staffIDTextBox = new System.Windows.Forms.TextBox();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.showStaffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // nameTextBox
            this.nameTextBox.Location = new System.Drawing.Point(20, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(280, 22);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.PlaceholderText = "Name";
            
            // addressTextBox
            this.addressTextBox.Location = new System.Drawing.Point(20, 50);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(280, 22);
            this.addressTextBox.TabIndex = 1;
            this.addressTextBox.PlaceholderText = "Address";
            
            // phoneTextBox
            this.phoneTextBox.Location = new System.Drawing.Point(20, 80);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(280, 22);
            this.phoneTextBox.TabIndex = 2;
            this.phoneTextBox.PlaceholderText = "Phone Number";
            
            // staffIDTextBox
            this.staffIDTextBox.Location = new System.Drawing.Point(20, 110);
            this.staffIDTextBox.Name = "staffIDTextBox";
            this.staffIDTextBox.Size = new System.Drawing.Size(280, 22);
            this.staffIDTextBox.TabIndex = 3;
            this.staffIDTextBox.PlaceholderText = "Staff ID";
            
            // roleTextBox
            this.roleTextBox.Location = new System.Drawing.Point(20, 140);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(280, 22);
            this.roleTextBox.TabIndex = 4;
            this.roleTextBox.PlaceholderText = "Role";

            // addStaffButton
            this.addStaffButton.Location = new System.Drawing.Point(20, 180);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(280, 30);
            this.addStaffButton.TabIndex = 5;
            this.addStaffButton.Text = "Add Staff";
            this.addStaffButton.UseVisualStyleBackColor = true;
            this.addStaffButton.BackColor = System.Drawing.Color.FromArgb(50, 150, 255);
            this.addStaffButton.ForeColor = System.Drawing.Color.White;
            this.addStaffButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);

            // showStaffButton
            this.showStaffButton.Location = new System.Drawing.Point(20, 220);
            this.showStaffButton.Name = "showStaffButton";
            this.showStaffButton.Size = new System.Drawing.Size(280, 30);
            this.showStaffButton.TabIndex = 6;
            this.showStaffButton.Text = "Show Staff";
            this.showStaffButton.UseVisualStyleBackColor = true;
            this.showStaffButton.BackColor = System.Drawing.Color.FromArgb(50, 150, 255);
            this.showStaffButton.ForeColor = System.Drawing.Color.White;
            this.showStaffButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.showStaffButton.Click += new System.EventHandler(this.showStaffButton_Click);

            // StaffManagementForm
            this.ClientSize = new System.Drawing.Size(320, 270);
            this.Controls.Add(this.showStaffButton);
            this.Controls.Add(this.addStaffButton);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(this.staffIDTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "StaffManagementForm";
            this.Text = "Staff Management";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
