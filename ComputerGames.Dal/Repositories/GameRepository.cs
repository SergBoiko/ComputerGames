using System.Collections.Generic;
using System.Data.SqlClient;
using ComputerGames.Dal.Entites;
using ComputerGames.Dal.Repositories.Interfaces;
using Dapper;

namespace ComputerGames.Dal.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly string _connectionString = @"Data Source=PC-FRRDIP22G24A\SQLEXPRESS;Initial Catalog=ComputerGames;Integrated Security=True";

        public void Create(GameEntity model)
        {
            var sql = $"INSERT INTO Games (Name, PublisherId, GenreId, ReleaseDate) VALUES ('{model.Name}',{model.PublisherId},{model.GenreId},'{model.ReleaseDate}');";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute(sql);
                connection.Close();
            };
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<GameEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(GameEntity model)
        {
            throw new System.NotImplementedException();
        }
    }
}
