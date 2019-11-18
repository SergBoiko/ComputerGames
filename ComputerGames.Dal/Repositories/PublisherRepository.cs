using System.Collections.Generic;
using System.Data.SqlClient;
using ComputerGames.Dal.Entites;
using ComputerGames.Dal.Repositories.Interfaces;
using Dapper;

namespace ComputerGames.Dal.Repositories
{
    public class PublisherRepository : Repository, IPublisherRepository
    {
        public void Create(PublisherEntity model)
        {
            var sql = $"INSERT INTO Publishers (Name, LicenceNumber) OUTPUT INSERTED.Id VALUES ('{model.Name}',{model.LicenceNumber});";

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

        public List<PublisherEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(PublisherEntity model)
        {
            throw new System.NotImplementedException();
        }
    }
}
