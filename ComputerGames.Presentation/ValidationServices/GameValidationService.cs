using System;
using System.Collections.Generic;
using ComputerGames.Core.Requests;
using ComputerGames.Core.Services;
using ComputerGames.Core.Services.Interfaces;
using ComputerGames.Presentation.ValidationServices.Interfaces;
using ComputerGames.Presentation.ViewModels;

namespace ComputerGames.Presentation.ValidationServices
{
    public class GameValidationService : ValidationService, IGameValidationService
    {
        private readonly DateTime minReleaseDate = new DateTime(1980, 1, 1);

        private readonly IGameService gameService;

        public GameValidationService()
        {
            this.gameService = new GameService();
        }

        public void Create(CreateGameViewModel createGameViewModel)
        {
            Validate(createGameViewModel);

            if (createGameViewModel.ReleaseDate < minReleaseDate ||
                createGameViewModel.ReleaseDate > DateTime.Now)
            {
                throw new ArgumentException("DateTime should be between 01/01/1980 and current date.");
            }

            gameService.Create(new CreateGameRequest()
            {
                GenreId = createGameViewModel.GenreId.Value,
                Name = createGameViewModel.Name,
                PublisherId = createGameViewModel.PublisherId.Value,
                ReleaseDate = createGameViewModel.ReleaseDate
            });
        }

        public void Delete(string name, DateTime releaseDate)
        {
            throw new NotImplementedException();
        }

        public List<GameViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(CreateGameViewModel updateGameViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
