using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using StudentsProject.Models;

namespace StudentsProject.Services
{
    public class GroupsProvider
    {
        private SqlConnection _connection;

        public GroupsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<StudentsGroup> GetAllWithSpecialties()
        {
            var groups = new List<StudentsGroup>();
            try
            {
                _connection.Open();
                var command = new SqlCommand(@"
                    SELECT
                        Groups.[Id],
                        Groups.[Name],
                        Groups.[Year],
                        Groups.[Specialty_id],
                        Specialties.[Code],
                        Specialties.[Name]
                    FROM
                        [Groups]
                    LEFT JOIN
                        [Specialties]
                    ON Specialties.[Id] = Groups.[Specialty_id]
                ", _connection);

                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var group = new StudentsGroup
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Year = reader.GetInt32(2),
                            Specialty_id = reader.GetInt32(3),
                            Specialty = new Specialty
                            {
                                Id = reader.GetInt32(3),
                                Code = reader.GetString(4),
                                Name = reader.GetString(5)
                            }
                        };
                        groups.Add(group);
                    }
                }

            }
            finally
            {
                _connection.Close();
            }
            return groups;
        }

        public List<StudentsGroup> GetAll()
        {
            var groups = new List<StudentsGroup>();
            try
            {
                _connection.Open();
                var command = new SqlCommand(@"
                    SELECT
                        [Id], [Name], [Year], [Specialty_id]
                    FROM
                        [Groups]
                ", _connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var group = new StudentsGroup
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Year = reader.GetInt32(2),
                            Specialty_id = reader.GetInt32(3),
                        };
                        groups.Add(group);
                    }
                }

            }
            finally
            {
                _connection.Close();
            }
            return groups;
        }

        public bool Add(StudentsGroup data)
        {
            return true;
        }

        public bool Update(int id, StudentsGroup data)
        {
            return true;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}
