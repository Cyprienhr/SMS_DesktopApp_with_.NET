namespace StudentManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRefresh;

        private void InitializeComponent()
        {
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // DataGridView
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStudents.Size = new System.Drawing.Size(560, 300);
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Buttons
            this.buttonAdd.Text = "Add Student";
            this.buttonAdd.Location = new System.Drawing.Point(12, 320);
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            this.buttonEdit.Text = "Edit";
            this.buttonEdit.Location = new System.Drawing.Point(120, 320);
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);

            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Location = new System.Drawing.Point(220, 320);
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);

            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.Location = new System.Drawing.Point(320, 320);
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRefresh);
            this.Text = "Student Management System";
            this.ResumeLayout(false);
        }
    }
}
