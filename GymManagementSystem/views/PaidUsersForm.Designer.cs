namespace GymManagementSystem.Views
{
    partial class PaidUsersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView paidUsersDataGridView;
        private System.Windows.Forms.Button generatePdfButton;

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
            this.paidUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.generatePdfButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paidUsersDataGridView)).BeginInit();
            this.SuspendLayout();
            
            // paidUsersDataGridView
            this.paidUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paidUsersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.paidUsersDataGridView.Name = "paidUsersDataGridView";
            this.paidUsersDataGridView.RowHeadersWidth = 51;
            this.paidUsersDataGridView.RowTemplate.Height = 24;
            this.paidUsersDataGridView.Size = new System.Drawing.Size(760, 400);
            this.paidUsersDataGridView.TabIndex = 0;

            // generatePdfButton
            this.generatePdfButton.Location = new System.Drawing.Point(12, 420);
            this.generatePdfButton.Name = "generatePdfButton";
            this.generatePdfButton.Size = new System.Drawing.Size(150, 30);
            this.generatePdfButton.TabIndex = 1;
            this.generatePdfButton.Text = "Generate PDF Report";
            this.generatePdfButton.UseVisualStyleBackColor = true;
            this.generatePdfButton.BackColor = System.Drawing.Color.FromArgb(50, 150, 255);
            this.generatePdfButton.ForeColor = System.Drawing.Color.White;
            this.generatePdfButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.generatePdfButton.Click += new System.EventHandler(this.generatePdfButton_Click);

            // PaidUsersForm
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.generatePdfButton);
            this.Controls.Add(this.paidUsersDataGridView);
            this.Name = "PaidUsersForm";
            this.Text = "Paid Users";
            ((System.ComponentModel.ISupportInitialize)(this.paidUsersDataGridView)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
