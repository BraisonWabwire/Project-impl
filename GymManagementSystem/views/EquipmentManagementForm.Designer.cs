namespace GymManagementSystem.Views
{
    partial class EquipmentManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button addEquipmentButton;
        private System.Windows.Forms.Button showEquipmentButton;
        private System.Windows.Forms.TextBox equipmentNameTextBox;
        private System.Windows.Forms.TextBox equipmentIDTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;

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
            this.addEquipmentButton = new System.Windows.Forms.Button();
            this.showEquipmentButton = new System.Windows.Forms.Button();
            this.equipmentNameTextBox = new System.Windows.Forms.TextBox();
            this.equipmentIDTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            
            this.SuspendLayout();
            
            // 
            // addEquipmentButton
            // 
            this.addEquipmentButton.Location = new System.Drawing.Point(20, 150);
            this.addEquipmentButton.Name = "addEquipmentButton";
            this.addEquipmentButton.Size = new System.Drawing.Size(200, 30);
            this.addEquipmentButton.TabIndex = 0;
            this.addEquipmentButton.Text = "Add Equipment";
            this.addEquipmentButton.UseVisualStyleBackColor = true;
            this.addEquipmentButton.Click += new System.EventHandler(this.addEquipmentButton_Click);
            
            // 
            // showEquipmentButton
            // 
            this.showEquipmentButton.Location = new System.Drawing.Point(20, 190);
            this.showEquipmentButton.Name = "showEquipmentButton";
            this.showEquipmentButton.Size = new System.Drawing.Size(200, 30);
            this.showEquipmentButton.TabIndex = 1;
            this.showEquipmentButton.Text = "Show Equipment";
            this.showEquipmentButton.UseVisualStyleBackColor = true;
            this.showEquipmentButton.Click += new System.EventHandler(this.showEquipmentButton_Click);
            
            // 
            // equipmentNameTextBox
            // 
            this.equipmentNameTextBox.Location = new System.Drawing.Point(20, 20);
            this.equipmentNameTextBox.Name = "equipmentNameTextBox";
            this.equipmentNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.equipmentNameTextBox.TabIndex = 2;
            this.equipmentNameTextBox.PlaceholderText = "Enter equipment name";
            
            // 
            // equipmentIDTextBox
            // 
            this.equipmentIDTextBox.Location = new System.Drawing.Point(20, 60);
            this.equipmentIDTextBox.Name = "equipmentIDTextBox";
            this.equipmentIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.equipmentIDTextBox.TabIndex = 3;
            this.equipmentIDTextBox.PlaceholderText = "Enter equipment ID";
            
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(20, 100);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.PlaceholderText = "Enter description";
            
            // 
            // EquipmentManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(240, 240);
            this.Controls.Add(this.addEquipmentButton);
            this.Controls.Add(this.showEquipmentButton);
            this.Controls.Add(this.equipmentNameTextBox);
            this.Controls.Add(this.equipmentIDTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "EquipmentManagementForm";
            this.Text = "Equipment Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
