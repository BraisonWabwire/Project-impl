namespace GymManagementSystem.Views
{
    partial class MembershipPaymentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button processPaymentButton;
        private System.Windows.Forms.Button showPaidUsersButton;

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
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.processPaymentButton = new System.Windows.Forms.Button();
            this.showPaidUsersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // memberIDTextBox
            this.memberIDTextBox.Location = new System.Drawing.Point(20, 20);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(280, 22);
            this.memberIDTextBox.TabIndex = 0;
            this.memberIDTextBox.PlaceholderText = "Member ID";
            
            // amountTextBox
            this.amountTextBox.Location = new System.Drawing.Point(20, 50);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(280, 22);
            this.amountTextBox.TabIndex = 1;
            this.amountTextBox.PlaceholderText = "Amount";
            
            // processPaymentButton
            this.processPaymentButton.Location = new System.Drawing.Point(20, 80);
            this.processPaymentButton.Name = "processPaymentButton";
            this.processPaymentButton.Size = new System.Drawing.Size(280, 30);
            this.processPaymentButton.TabIndex = 2;
            this.processPaymentButton.Text = "Process Payment";
            this.processPaymentButton.UseVisualStyleBackColor = true;
            this.processPaymentButton.BackColor = System.Drawing.Color.FromArgb(50, 150, 255);
            this.processPaymentButton.ForeColor = System.Drawing.Color.White;
            this.processPaymentButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.processPaymentButton.Click += new System.EventHandler(this.processPaymentButton_Click);
            
            // showPaidUsersButton
            this.showPaidUsersButton.Location = new System.Drawing.Point(20, 120);
            this.showPaidUsersButton.Name = "showPaidUsersButton";
            this.showPaidUsersButton.Size = new System.Drawing.Size(280, 30);
            this.showPaidUsersButton.TabIndex = 3;
            this.showPaidUsersButton.Text = "Show Paid Users";
            this.showPaidUsersButton.UseVisualStyleBackColor = true;
            this.showPaidUsersButton.BackColor = System.Drawing.Color.FromArgb(50, 150, 255);
            this.showPaidUsersButton.ForeColor = System.Drawing.Color.White;
            this.showPaidUsersButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.showPaidUsersButton.Click += new System.EventHandler(this.showPaidUsersButton_Click);
            
            // MembershipPaymentForm
            this.ClientSize = new System.Drawing.Size(320, 170);
            this.Controls.Add(this.showPaidUsersButton);
            this.Controls.Add(this.processPaymentButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.memberIDTextBox);
            this.Name = "MembershipPaymentForm";
            this.Text = "Membership Payment";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
