using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsProject.Models;

namespace StudentsProject.Views
{
    public partial class MainForm : Form
    {
        public event Action showFormStudent;
        public event Action showFormSpecialty;
        public event Action LoadData;
        public MainForm()
        {
            InitializeComponent();
            fullInfoStudentView.AutoGenerateColumns = false;
        }

        private void showStudents_Click(object sender, EventArgs e)
        {
            showFormStudent();
        }

        public void ShowData(List<Student> student)
        {
            fullInfoStudentView.DataSource = student;
        }

        private void showSpecialtyButton_Click(object sender, EventArgs e)
        {
            showFormSpecialty();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void fullInfoStudentView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var column = fullInfoStudentView.Columns[e.ColumnIndex];

            if (column.Name != "GroupColumn")
                return;

            var student = fullInfoStudentView.Rows[e.RowIndex].DataBoundItem as Student;
            e.Value = student.Group.Name;
        }
    }
}
