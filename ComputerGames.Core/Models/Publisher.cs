using System.Collections.Generic;

namespace ComputerGames.Core.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int LicenceNumber { get; set; }

        public List<Game> Games { get; set; }
    }
}