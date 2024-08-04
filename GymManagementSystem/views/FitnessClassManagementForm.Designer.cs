namespace GymManagementSystem.Views
{
    partial class FitnessClassManagementForm
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
            this.classNameTextBox = new System.Windows.Forms.TextBox();
            this.instructorTextBox = new System.Windows.Forms.TextBox();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addClassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // classNameTextBox
            this.classNameTextBox.Location = new System.Drawing.Point(20, 20);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.Size = new System.Drawing.Size(280, 22);
            this.classNameTextBox.TabIndex = 0;
            this.classNameTextBox.PlaceholderText = "Class Name";
            
            // instructorTextBox
            this.instructorTextBox.Location = new System.Drawing.Point(20, 50);
            this.instructorTextBox.Name = "instructorTextBox";
            this.instructorTextBox.Size = new System.Drawing.Size(280, 22);
            this.instructorTextBox.TabIndex = 1;
            this.instructorTextBox.PlaceholderText = "Instructor";
            
            // startTimePicker
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(20, 80);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(280, 22);
            this.startTimePicker.TabIndex = 2;
            
            // endTimePicker
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(20, 110);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(280, 22);
            this.endTimePicker.TabIndex = 3;
            
            // addClassButton
            this.addClassButton.Location = new System.Drawing.Point(20, 150);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(280, 30);
            this.addClassButton.TabIndex = 4;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.BackColor = System.Drawing.Color.FromArgb(50, 150, 255);
            this.addClassButton.ForeColor = System.Drawing.Color.White;
            this.addClassButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);

            // FitnessClassManagementForm
            this.ClientSize = new System.Drawing.Size(320, 220);
            this.Controls.Add(this.addClassButton);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.instructorTextBox);
            this.Controls.Add(this.classNameTextBox);
            this.Name = "FitnessClassManagementForm";
            this.Text = "Fitness Class Management";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox classNameTextBox;
        private System.Windows.Forms.TextBox instructorTextBox;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Button addClassButton;
    }
}
