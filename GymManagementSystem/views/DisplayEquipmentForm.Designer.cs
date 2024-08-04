namespace GymManagementSystem.Views
{
    partial class DisplayEquipmentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView equipmentDataGridView;
        private System.Windows.Forms.Button deleteEquipmentButton;

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
            this.equipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteEquipmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataGridView)).BeginInit();
            this.SuspendLayout();
            
            // equipmentDataGridView
            this.equipmentDataGridView.AllowUserToAddRows = false;
            this.equipmentDataGridView.AllowUserToDeleteRows = false;
            this.equipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentDataGridView.Location = new System.Drawing.Point(12, 12);
            this.equipmentDataGridView.Name = "equipmentDataGridView";
            this.equipmentDataGridView.ReadOnly = true;
            this.equipmentDataGridView.RowHeadersWidth = 51;
            this.equipmentDataGridView.RowTemplate.Height = 24;
            this.equipmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.equipmentDataGridView.Size = new System.Drawing.Size(600, 350);
            this.equipmentDataGridView.TabIndex = 0;
            
            // deleteEquipmentButton
            this.deleteEquipmentButton.Location = new System.Drawing.Point(12, 370);
            this.deleteEquipmentButton.Name = "deleteEquipmentButton";
            this.deleteEquipmentButton.Size = new System.Drawing.Size(600, 30);
            this.deleteEquipmentButton.TabIndex = 1;
            this.deleteEquipmentButton.Text = "Delete Selected Equipment";
            this.deleteEquipmentButton.UseVisualStyleBackColor = true;
            this.deleteEquipmentButton.BackColor = System.Drawing.Color.FromArgb(255, 50, 50);
            this.deleteEquipmentButton.ForeColor = System.Drawing.Color.White;
            this.deleteEquipmentButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.deleteEquipmentButton.Click += new System.EventHandler(this.deleteEquipmentButton_Click);

            // DisplayEquipmentForm
            this.ClientSize = new System.Drawing.Size(630, 420);
            this.Controls.Add(this.deleteEquipmentButton);
            this.Controls.Add(this.equipmentDataGridView);
            this.Name = "DisplayEquipmentForm";
            this.Text = "Display Equipment";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataGridView)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
