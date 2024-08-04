namespace GymManagementSystem.Views
{
    partial class MainPageForm
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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.memberManagementButton = new System.Windows.Forms.Button();
            this.paymentManagementButton = new System.Windows.Forms.Button();
            this.staffManagementButton = new System.Windows.Forms.Button();
            this.equipmentManagementButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // descriptionLabel
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.descriptionLabel.Location = new System.Drawing.Point(60, 40);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(280, 30);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "WELCOME TO \nGYM MANAGEMENT SYSTEM";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // memberManagementButton
            this.memberManagementButton.Location = new System.Drawing.Point(100, 100);
            this.memberManagementButton.Name = "memberManagementButton";
            this.memberManagementButton.Size = new System.Drawing.Size(200, 40);
            this.memberManagementButton.TabIndex = 1;
            this.memberManagementButton.Text = "Manage Members";
            this.memberManagementButton.UseVisualStyleBackColor = true;
            this.memberManagementButton.Click += new System.EventHandler(this.memberManagementButton_Click);

            // paymentManagementButton
            this.paymentManagementButton.Location = new System.Drawing.Point(100, 150);
            this.paymentManagementButton.Name = "paymentManagementButton";
            this.paymentManagementButton.Size = new System.Drawing.Size(200, 40);
            this.paymentManagementButton.TabIndex = 2;
            this.paymentManagementButton.Text = "Process Payment";
            this.paymentManagementButton.UseVisualStyleBackColor = true;
            this.paymentManagementButton.Click += new System.EventHandler(this.paymentManagementButton_Click);

            // staffManagementButton
            this.staffManagementButton.Location = new System.Drawing.Point(100, 200);
            this.staffManagementButton.Name = "staffManagementButton";
            this.staffManagementButton.Size = new System.Drawing.Size(200, 40);
            this.staffManagementButton.TabIndex = 3;
            this.staffManagementButton.Text = "Manage Staff";
            this.staffManagementButton.UseVisualStyleBackColor = true;
            this.staffManagementButton.Click += new System.EventHandler(this.staffManagementButton_Click);

            // equipmentManagementButton
            this.equipmentManagementButton.Location = new System.Drawing.Point(100, 250);
            this.equipmentManagementButton.Name = "equipmentManagementButton";
            this.equipmentManagementButton.Size = new System.Drawing.Size(200, 40);
            this.equipmentManagementButton.TabIndex = 4;
            this.equipmentManagementButton.Text = "Manage gym Equipments";
            this.equipmentManagementButton.UseVisualStyleBackColor = true;
            this.equipmentManagementButton.Click += new System.EventHandler(this.equipmentManagementButton_Click);

            // exitButton
            this.exitButton.Location = new System.Drawing.Point(150, 300);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 30);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);

            // MainPageForm
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.memberManagementButton);
            this.Controls.Add(this.paymentManagementButton);
            this.Controls.Add(this.staffManagementButton);
            this.Controls.Add(this.equipmentManagementButton);
            this.Controls.Add(this.exitButton);
            this.Name = "MainPageForm";
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button memberManagementButton;
        private System.Windows.Forms.Button paymentManagementButton;
        private System.Windows.Forms.Button staffManagementButton;
        private System.Windows.Forms.Button equipmentManagementButton;
        private System.Windows.Forms.Button exitButton;
    }
}
