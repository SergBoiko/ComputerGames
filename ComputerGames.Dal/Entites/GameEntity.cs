using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGames.Dal.Entites
{
    public class GameEntity
    {
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int GenreId { get; set; }

        public int PublisherId { get; set; }
    }
}
