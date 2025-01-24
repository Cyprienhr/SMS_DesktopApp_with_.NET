using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StudentManagementSystem
{
    public partial class StudentForm : Form
    {
        private int? studentId = null;

        public StudentForm(int? id = null, string name = "", int age = 0, string grade = "")
        {
            studentId = id;
            InitializeComponent();

            if (id.HasValue)
            {
                textBoxName.Text = name;
                numericUpDownAge.Value = age;
                textBoxGrade.Text = grade;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string grade = textBoxGrade.Text.Trim();
            int age;

            // Validation: Ensure no field is empty
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(grade))
            {
                MessageBox.Show("Name and Grade cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(name)) textBoxName.Focus();
                else textBoxGrade.Focus();
                return;
            }

            // Validation: Ensure Age is a valid number
            if (!int.TryParse(numericUpDownAge.Text, out age) || age <= 0 || age > 120)
            {
                MessageBox.Show("Please enter a valid age between 1 and 120.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDownAge.Focus();
                return;
            }

            // Validation: Ensure Name contains only letters
            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                return;
            }

            // Validation: Ensure Grade contains only letters
            if (!Regex.IsMatch(grade, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Grade can only contain letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxGrade.Focus();
                return;
            }

            // If all validations pass, save the student data
            if (studentId.HasValue)
            {
                DatabaseHelper.UpdateStudent(studentId.Value, name, age, grade);
            }
            else
            {
                DatabaseHelper.AddStudent(name, age, grade);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
