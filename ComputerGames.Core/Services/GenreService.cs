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
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository genreRepository;

        public GenreService()
        {
            this.genreRepository = new GenreRepository();
        }

        public int Create(CreateGenreRequest request)
        {
            var genreEntity = new GenreEntity()
            {
                Description = request.Description
            };

            genreRepository.Create(genreEntity);

            return genreEntity.Id;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Genre> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Genre model)
        {
            throw new NotImplementedException();
        }
    }
}
