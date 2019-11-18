using ComputerGames.Presentation.ViewModels;
using System;
using System.Collections.Generic;

namespace ComputerGames.Presentation.ValidationServices.Interfaces
{
    public interface IGenreValidationService
    {
        int Create(CreateGenreViewModel createGenreViewModel);
        void Update(CreateGenreViewModel updateGameViewModel);
        void Delete(string name, DateTime releaseDate);
        List<GenreViewModel> GetAll();
    }
}
