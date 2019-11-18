using System;

namespace ComputerGames.Presentation.ViewModels
{
    public class GameViewModel
    {
        public string Name { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public GenreViewModel Genre { get; set; }
        
        public PublisherViewModel Publisher { get; set; }
    }
}
