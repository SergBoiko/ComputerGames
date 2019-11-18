using System.Collections.Generic;

namespace ComputerGames.Presentation.ViewModels
{
    public class GenreViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<GameViewModel> Games { get; set; }
    }
}
