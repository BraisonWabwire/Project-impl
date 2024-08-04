namespace GymManagementSystem.Views
{
    partial class MemberManagementForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.membershipTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.showMembersButton = new System.Windows.Forms.Button();
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
            
            // memberIDTextBox
            this.memberIDTextBox.Location = new System.Drawing.Point(20, 110);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(280, 22);
            this.memberIDTextBox.TabIndex = 3;
            this.memberIDTextBox.PlaceholderText = "Member ID";
            
            // membershipTypeComboBox
            this.membershipTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.membershipTypeComboBox.FormattingEnabled = true;
            this.membershipTypeComboBox.Items.AddRange(new object[] { "Basic", "Premium" });
            this.membershipTypeComboBox.Location = new System.Drawing.Point(20, 140);
            this.membershipTypeComboBox.Name = "membershipTypeComboBox";
            this.membershipTypeComboBox.Size = new System.Drawing.Size(280, 24);
            this.membershipTypeComboBox.TabIndex = 4;
            
            // addMemberButton
            this.addMemberButton.Location = new System.Drawing.Point(20, 180);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(280, 30);
            this.addMemberButton.TabIndex = 5;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.BackColor = System.Drawing.Color.FromArgb(50, 150, 255);
            this.addMemberButton.ForeColor = System.Drawing.Color.White;
            this.addMemberButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);

            // showMembersButton
            this.showMembersButton.Location = new System.Drawing.Point(20, 220);
            this.showMembersButton.Name = "showMembersButton";
            this.showMembersButton.Size = new System.Drawing.Size(280, 30);
            this.showMembersButton.TabIndex = 6;
            this.showMembersButton.Text = "Show Members";
            this.showMembersButton.UseVisualStyleBackColor = true;
            this.showMembersButton.BackColor = System.Drawing.Color.FromArgb(50, 150, 255);
            this.showMembersButton.ForeColor = System.Drawing.Color.White;
            this.showMembersButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.showMembersButton.Click += new System.EventHandler(this.showMembersButton_Click);

            // MemberManagementForm
            this.ClientSize = new System.Drawing.Size(320, 270);
            this.Controls.Add(this.showMembersButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.membershipTypeComboBox);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "MemberManagementForm";
            this.Text = "Member Management";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.ComboBox membershipTypeComboBox;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button showMembersButton;
    }
}
