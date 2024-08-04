namespace GymManagementSystem.Views
{
    partial class DisplayStaffForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView staffDataGridView;
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
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.SuspendLayout();
            
            // staffDataGridView
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Location = new System.Drawing.Point(12, 12);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.RowHeadersWidth = 51;
            this.staffDataGridView.RowTemplate.Height = 24;
            this.staffDataGridView.Size = new System.Drawing.Size(760, 400);
            this.staffDataGridView.TabIndex = 0;

            // deleteButton
            this.deleteButton.Location = new System.Drawing.Point(12, 420);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 30);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);

            // DisplayStaffForm
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.staffDataGridView);
            this.Name = "DisplayStaffForm";
            this.Text = "Display Staff";
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
