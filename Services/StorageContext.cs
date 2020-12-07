using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentsProject.Services
{
    public class StorageContext
    {
        public SpecialtiesProvider Specialties { get; }
        public GroupsProvider Groups { get; private set; }
        public StudentsProvider Students { get; private set; }

        public StorageContext()
        {
            var connection = CreateConnection();
            Specialties = new SpecialtiesProvider(connection);
            Groups = new GroupsProvider(connection);
            Students = new StudentsProvider(connection);
        }

        private SqlConnection CreateConnection()
        {
            var builder = new SqlConnectionStringBuilder 
            { 
                DataSource = @"DESKTOP-FPFLMOT",
                InitialCatalog = "StudentStorage",
                IntegratedSecurity = true
            };
            var strConnection = builder.ToString();
            return new SqlConnection(strConnection);
        }
    }
}
