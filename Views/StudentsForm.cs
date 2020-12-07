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
    public partial class StudentsForm : Form
    {
        public event Action LoadData;
        public event Action<Student> ChangeData;
        public event Action AddStudent;
        public StudentsForm()
        {
            InitializeComponent();
            studentsView.AutoGenerateColumns = false;
        }

        public void ShowData(List<Student> students)
        {
            studentsView.DataSource = students;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var row = studentsView.SelectedRows[0]; //страна выделенная пользователем
            var student = row.DataBoundItem as Student; //получили студента выделенного
            ChangeData(student);
        }

        private void studentsView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var column = studentsView.Columns[e.ColumnIndex];

            if (column.Name != "GroupColumn")
                return;

            var student = studentsView.Rows[e.RowIndex].DataBoundItem as Student;
            e.Value = student.Group.Name;
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
