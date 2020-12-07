using StudentsProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsProject.Views
{
    public partial class StudentsEditorForm : Form
    {
        private int studentId;
        public Student ChangedData {
            get
            {
                var group = groupBox.SelectedItem as StudentsGroup;
                return new Student
                {
                    Id = studentId,
                    Name = nameBox.Text,
                    Surname = surnameBox.Text,
                    Group = group,
                    Group_id = group.Id
                };
            }
        }

        public Student AddStudentData
        {
            get
            {
                var group = groupBox.SelectedItem as StudentsGroup;
                return new Student
                {
                    Id = studentId,
                    Name = nameBox.Text,
                    Surname = surnameBox.Text,
                    Group = group
                };
            }
        }

        public StudentsEditorForm()
        {
            InitializeComponent();
            acceptButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
        }
        
        public DialogResult ShowDialog(List<StudentsGroup> groups)
        {
            groupBox.DataSource = groups;
            groupBox.DisplayMember = "Name";

            return ShowDialog();
        }

        public DialogResult ShowDialog(Student data, List<StudentsGroup> groups)
        {
            if (data == null)
                data = new Student();

            studentId = data.Id;

            nameBox.Text = data.Name;
            surnameBox.Text = data.Surname;

            //Выпадающий список групп
            groupBox.DataSource = groups;
            groupBox.DisplayMember = "Name";
            StudentsGroup selectedGroup = null;
            foreach(var group in groups)
            {
                if(group.Id == data.Group.Id)
                {
                    selectedGroup = group;
                    break;
                }
            }
            groupBox.SelectedItem = selectedGroup;

            return ShowDialog();
        }
    }
}
