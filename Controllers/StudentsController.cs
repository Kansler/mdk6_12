using System;
using StudentsProject.Views;
using StudentsProject.Services;
using StudentsProject.Models;
using System.Collections.Generic;

namespace StudentsProject.Controllers
{
    public class StudentsController
    {
        private StudentsForm _view;
        private StorageContext _context;
        public StudentsController(StudentsForm view, StorageContext context)
        {
            _view = view;
            _context = context;
            _view.LoadData += LoadDataHandler;
            _view.ChangeData += ChangeDataHandler;
            _view.AddStudent += AddStudentHandler;
        }
        
        public void AddStudentHandler()
        {
            var editor = new StudentsEditorForm();
            var groups = _context.Groups.GetAll();
            var result = editor.ShowDialog(groups);

            if (result != System.Windows.Forms.DialogResult.OK)
                return;

            var addStudentData = editor.AddStudentData;
            _context.Students.Add(addStudentData);

            LoadDataHandler();
        }

        private void LoadDataHandler()
        {
            var students = _context.Students.GetAllWithGroups();
            _view.ShowData(students);
        }

        private void ChangeDataHandler(Student data)
        {
            var editor = new StudentsEditorForm();

            var groups = _context.Groups.GetAll();

            var result = editor.ShowDialog(data, groups);

            if (result != System.Windows.Forms.DialogResult.OK)
                return;

            var changedStudentData = editor.ChangedData;
            _context.Students.Update(data.Id, changedStudentData);

            LoadDataHandler();
        }
    }
}
