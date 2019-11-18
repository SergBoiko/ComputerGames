using System.Collections.Generic;

namespace ComputerGames.Core.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Game> Games { get; set; }
    }
}