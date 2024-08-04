namespace GymManagementSystem.Views
{
    partial class MainForm
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
            this.memberManagementButton = new System.Windows.Forms.Button();
            this.staffManagementButton = new System.Windows.Forms.Button();
            this.fitnessClassManagementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // memberManagementButton
            this.memberManagementButton.Location = new System.Drawing.Point(50, 30);
            this.memberManagementButton.Name = "memberManagementButton";
            this.memberManagementButton.Size = new System.Drawing.Size(200, 40);
            this.memberManagementButton.TabIndex = 0;
            this.memberManagementButton.Text = "Member Management";
            this.memberManagementButton.UseVisualStyleBackColor = true;
            this.memberManagementButton.BackColor = System.Drawing.Color.FromArgb(50, 150, 255);
            this.memberManagementButton.ForeColor = System.Drawing.Color.White;
            this.memberManagementButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.memberManagementButton.Click += new System.EventHandler(this.memberManagementButton_Click);

            // staffManagementButton
            this.staffManagementButton.Location = new System.Drawing.Point(50, 80);
            this.staffManagementButton.Name = "staffManagementButton";
            this.staffManagementButton.Size = new System.Drawing.Size(200, 40);
            this.staffManagementButton.TabIndex = 1;
            this.staffManagementButton.Text = "Staff Management";
            this.staffManagementButton.UseVisualStyleBackColor = true;
            this.staffManagementButton.BackColor = System.Drawing.Color.FromArgb(50, 150, 255);
            this.staffManagementButton.ForeColor = System.Drawing.Color.White;
            this.staffManagementButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.staffManagementButton.Click += new System.EventHandler(this.staffManagementButton_Click);

            // fitnessClassManagementButton
            this.fitnessClassManagementButton.Location = new System.Drawing.Point(50, 130);
            this.fitnessClassManagementButton.Name = "fitnessClassManagementButton";
            this.fitnessClassManagementButton.Size = new System.Drawing.Size(200, 40);
            this.fitnessClassManagementButton.TabIndex = 2;
            this.fitnessClassManagementButton.Text = "Fitness Class Management";
            this.fitnessClassManagementButton.UseVisualStyleBackColor = true;
            this.fitnessClassManagementButton.BackColor = System.Drawing.Color.FromArgb(50, 150, 255);
            this.fitnessClassManagementButton.ForeColor = System.Drawing.Color.White;
            this.fitnessClassManagementButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.fitnessClassManagementButton.Click += new System.EventHandler(this.fitnessClassManagementButton_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.fitnessClassManagementButton);
            this.Controls.Add(this.staffManagementButton);
            this.Controls.Add(this.memberManagementButton);
            this.Name = "MainForm";
            this.Text = "Gym Management System";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button memberManagementButton;
        private System.Windows.Forms.Button staffManagementButton;
        private System.Windows.Forms.Button fitnessClassManagementButton;
    }
}
