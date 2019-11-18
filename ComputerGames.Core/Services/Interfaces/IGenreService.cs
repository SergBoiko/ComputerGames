using ComputerGames.Core.Models;
using ComputerGames.Core.Requests;
using System.Collections.Generic;

namespace ComputerGames.Core.Services.Interfaces
{
    public interface IGenreService
    {
        List<Genre> GetAll();

        int Create(CreateGenreRequest request);

        void Update(Genre model);

        void Delete(int id);
    }
}
