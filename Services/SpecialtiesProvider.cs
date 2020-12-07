using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using StudentsProject.Models;

namespace StudentsProject.Services
{
    public class SpecialtiesProvider
    {
        private SqlConnection _connection;

        public SpecialtiesProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Specialty> GetAll()
        {
            var specialties = new List<Specialty>();

            try
            {
                _connection.Open();
                var cmd = new SqlCommand(
                    @"
                        SELECT 
                            [Id], [Code], [Name]
                        FROM
                            [Specialties]
                    ",
                    _connection
                );

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var spec = new Specialty
                        {
                            Id = reader.GetInt32(0),
                            Code = reader.GetString(1),
                            Name = reader.GetString(2)
                        };

                        specialties.Add(spec);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return specialties;
        }

        public bool Add(Specialty specialty)
        {
            var cmd = new SqlCommand(
                @"
                        INSERT INTO [Specialties]
                            ([Code], [Name])
                        VALUES
                            (@Code, @Name)
                    ",
                _connection
            );
            cmd.Parameters.AddWithValue("@Code", specialty.Code);
            cmd.Parameters.AddWithValue("@Name", specialty.Name);

            return MyExecuteNonQuery(cmd);
        }

        public bool Update(int id, Specialty newData)
        {
            var cmd = new SqlCommand(
                @"
                    UPDATE [Specialties]
                    SET
                        [Code] = @Code,
                        [Name] = @Name
                    WHERE
                        [Id] = @Id
                ",
                _connection
            );
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Code", newData.Code);
            cmd.Parameters.AddWithValue("@Name", newData.Name);

            return MyExecuteNonQuery(cmd);
        }

        public bool Delete(int id)
        {
            var cmd = new SqlCommand(
                @"
                    DELETE FROM [Specialties]
                    WHERE [Id] = @Id
                ",
                _connection
            );
            cmd.Parameters.AddWithValue("@Id", id);

            return MyExecuteNonQuery(cmd);
        }

        private bool MyExecuteNonQuery(SqlCommand cmd)
        {
            bool ok = false;

            try
            {
                _connection.Open();
                var affected = cmd.ExecuteNonQuery();
                ok = affected > 0;
            }
            finally
            {
                _connection.Close();
            }

            return ok;
        }

    }
}
