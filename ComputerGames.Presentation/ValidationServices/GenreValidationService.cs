using System;
using System.Collections.Generic;
using System.Linq;
using ComputerGames.Core.Requests;
using ComputerGames.Core.Services;
using ComputerGames.Core.Services.Interfaces;
using ComputerGames.Presentation.ValidationServices.Interfaces;
using ComputerGames.Presentation.ViewModels;

namespace ComputerGames.Presentation.ValidationServices
{
    public class GenreValidationService : ValidationService, IGenreValidationService
    {
        private readonly IGenreService genreService;

        public GenreValidationService()
        {
            this.genreService = new GenreService();
        }

        public int Create(CreateGenreViewModel createGenreViewModel)
        {
            Validate(createGenreViewModel);

            return genreService.Create(new CreateGenreRequest()
            {
                Description = createGenreViewModel.Description,
            });
        }

        public void Delete(string name, DateTime releaseDate)
        {
            throw new NotImplementedException();
        }

        public List<GenreViewModel> GetAll()
        {
            return genreService.GetAll().Select(x => new GenreViewModel()
            {
                Description = x.Description,
                Id = x.Id
            }).ToList();
        }

        public void Update(CreateGenreViewModel updateGameViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
