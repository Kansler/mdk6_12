using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using StudentsProject.Models;

namespace StudentsProject.Services
{
    public class StudentsProvider
    {
        private SqlConnection _connection;

        public StudentsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Student> GetAllWithGroups()
        {
            var students = new List<Student>();
            try
            {
                _connection.Open();
                var command = new SqlCommand(@"
                    SELECT
                        Students.[Id],
                        Students.[Name],
                        Students.[Surname],
                        Students.[Group_id],
                        Groups.[Name],
                        Groups.[Year]
                    FROM
                        [Students]
                    LEFT JOIN
                        [Groups]
                    ON
                        Groups.[id] = Students.[Group_id]
                    ", _connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var student = new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Surname = reader.GetString(2),
                            Group_id = reader.GetInt32(3),
                            Group = new StudentsGroup
                            {
                                Id = reader.GetInt32(3),
                                Name = reader.GetString(4),
                                Year = reader.GetInt32(5)
                            }
                        };
                        students.Add(student);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }
            return students;
        }

        public bool Add(Student data)
        {
            bool result = false;

            try
            {
                _connection.Open();
                var command = new SqlCommand(@"
                    INSERT INTO
                        [Students]
                        ([Name], [Surname], [Group_id])
                    VALUES
                        (@Name, @Surname, @Group_id)
                ", _connection);
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public bool Update(int id, Student data)
        {
            bool result = false;

            try
            {
                _connection.Open();
                var command = new SqlCommand(@"
                    UPDATE
                        [Students]
                    SET
                        [Name] = @Name,
                        [Surname] = @Surname,
                        [Group_id] = @Group_id
                    WHERE
                        [Id] = @Id
                ", _connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", data.Name);
                command.Parameters.AddWithValue("@Surname", data.Surname);
                command.Parameters.AddWithValue("@Group_id", data.Group_id);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }


            return result;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}
