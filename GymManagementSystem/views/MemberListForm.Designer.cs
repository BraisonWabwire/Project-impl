namespace GymManagementSystem.Views
{
    partial class MemberListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.Button deleteButton;

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
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            this.SuspendLayout();
            
            // membersDataGridView
            this.membersDataGridView.AllowUserToAddRows = false;
            this.membersDataGridView.AllowUserToDeleteRows = false;
            this.membersDataGridView.AllowUserToOrderColumns = true;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.ReadOnly = true;
            this.membersDataGridView.RowHeadersWidth = 51;
            this.membersDataGridView.RowTemplate.Height = 24;
            this.membersDataGridView.Size = new System.Drawing.Size(760, 400);
            this.membersDataGridView.TabIndex = 0;

            // deleteButton
            this.deleteButton.Location = new System.Drawing.Point(12, 418);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 30);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete Member";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);

            // MemberListForm
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.membersDataGridView);
            this.Name = "MemberListForm";
            this.Text = "Member List";
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
