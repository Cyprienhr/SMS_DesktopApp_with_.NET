using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            dataGridViewStudents.DataSource = DatabaseHelper.GetStudents();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new StudentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadStudents();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["StudentID"].Value);
                string name = dataGridViewStudents.SelectedRows[0].Cells["Name"].Value.ToString();
                int age = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["Age"].Value);
                string grade = dataGridViewStudents.SelectedRows[0].Cells["Grade"].Value.ToString();

                var form = new StudentForm(id, name, age, grade);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadStudents();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["StudentID"].Value);
                DatabaseHelper.DeleteStudent(id);
                LoadStudents();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
