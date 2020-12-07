using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsProject.Models;
using StudentsProject.Services;
using StudentsProject.Views;

namespace StudentsProject.Controllers
{
    public class MainController
    {
        private MainForm _view;
        private StorageContext _context;
        public MainController(MainForm view, StorageContext context)
        {
            _view = view;
            _context = context;
            _view.showFormStudent += ShowFormStudents;
            _view.showFormSpecialty += ShowFormSpecialty;
            _view.LoadData += LoadDataHandler;
        }
        
        public void LoadDataHandler()
        {
            var students = _context.Students.GetAllWithGroups();
            _view.ShowData(students);
        }

        public void ShowFormStudents()
        {
            var view = new StudentsForm();
            var controller = new StudentsController(view, _context);

            _view.Hide();
            view.ShowDialog();
            _view.Show();
        }

        public void ShowFormSpecialty()
        {
            var view = new SpecialtiesForm();
            var controller = new SpecialtiesController(_context, view);

            _view.Hide();
            view.ShowDialog();
            _view.Show();
        }
    }
}
