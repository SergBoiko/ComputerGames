using System;

namespace ComputerGames.Core.Requests
{
    public class CreateGameRequest
    {
        public string Name { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public int GenreId { get; set; }
        
        public int PublisherId { get; set; }
    }
}
