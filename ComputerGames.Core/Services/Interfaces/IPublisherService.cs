using ComputerGames.Core.Models;
using ComputerGames.Core.Requests;
using System.Collections.Generic;

namespace ComputerGames.Core.Services.Interfaces
{
    public interface IPublisherService
    {
        List<Publisher> GetAll();

        int Create(CreatePublisherRequest model);

        void Update(Publisher model);

        void Delete(int id);
    }
}
