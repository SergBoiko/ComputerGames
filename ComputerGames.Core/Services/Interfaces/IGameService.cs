using ComputerGames.Core.Models;
using ComputerGames.Core.Requests;
using System.Collections.Generic;

namespace ComputerGames.Core.Services.Interfaces
{
    public interface IGameService
    {
        List<Game> GetAll();

        void Create(CreateGameRequest request);

        void Update(Game model);

        void Delete(int id);
    }
}
