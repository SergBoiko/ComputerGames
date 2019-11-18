using System.Collections.Generic;
using System.Data.SqlClient;
using ComputerGames.Dal.Entites;
using ComputerGames.Dal.Repositories.Interfaces;
using Dapper;

namespace ComputerGames.Dal.Repositories
{
    public class GenreRepository : Repository, IGenreRepository
    {
        public void Create(GenreEntity model)
        {
            var sql = $"INSERT INTO Genres (Description) OUTPUT INSERTED.Id VALUES ('{model.Description}');";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var insertedId = (int)connection.ExecuteScalar(sql);
                connection.Close();

                model.Id = insertedId;
            };
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<GenreEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(GenreEntity model)
        {
            throw new System.NotImplementedException();
        }
    }
}
