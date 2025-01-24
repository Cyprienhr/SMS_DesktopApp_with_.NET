namespace StudentManagementSystem
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Button buttonSave;

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Name
            this.textBoxName.Location = new System.Drawing.Point(12, 12);
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.PlaceholderText = "Name";

            // Age
            this.numericUpDownAge.Location = new System.Drawing.Point(12, 50);
            this.numericUpDownAge.Maximum = 100;
            this.numericUpDownAge.Minimum = 1;

            // Grade
            this.textBoxGrade.Location = new System.Drawing.Point(12, 88);
            this.textBoxGrade.Size = new System.Drawing.Size(200, 20);
            this.textBoxGrade.PlaceholderText = "Grade";

            // Save Button
            this.buttonSave.Text = "Save";
            this.buttonSave.Location = new System.Drawing.Point(12, 126);
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // StudentForm
            this.ClientSize = new System.Drawing.Size(224, 161);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.buttonSave);
            this.Text = "Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
