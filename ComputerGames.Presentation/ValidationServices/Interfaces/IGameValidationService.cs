using ComputerGames.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGames.Presentation.ValidationServices.Interfaces
{
    public interface IGameValidationService
    {
        void Create(CreateGameViewModel createGameViewModel);
        void Update(CreateGameViewModel updateGameViewModel);
        void Delete(string name, DateTime releaseDate);
        List<GameViewModel> GetAll();
    }
}
