using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGames.Core.Models
{
    public class Game
    {
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        public Publisher Publisher { get; set; }
    }
}
