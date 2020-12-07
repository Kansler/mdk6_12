using StudentsProject.Controllers;
using StudentsProject.Services;
using StudentsProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var context = new StorageContext();
            //var specWindow = new SpecialtiesForm();
            //var specController = new SpecialtiesController(context, specWindow);

            var context = new StorageContext();
            var mainWindow = new MainForm();
            var mainController = new MainController(mainWindow, context);

            Application.Run(mainWindow);
        }
    }
}
