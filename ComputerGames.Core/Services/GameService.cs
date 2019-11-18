using ComputerGames.Core.Models;
using ComputerGames.Core.Requests;
using ComputerGames.Core.Services.Interfaces;
using ComputerGames.Dal.Entites;
using ComputerGames.Dal.Repositories;
using ComputerGames.Dal.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace ComputerGames.Core.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository gameRepository;

        public GameService()
        {
            this.gameRepository = new GameRepository();
        }

        public void Create(CreateGameRequest request)
        {
            gameRepository.Create(new GameEntity()
            {
                GenreId = request.GenreId,
                Name = request.Name,
                PublisherId = request.PublisherId,
                ReleaseDate = request.ReleaseDate
            });
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Game model)
        {
            throw new NotImplementedException();
        }
    }
}
