using System;
using ComputerGames.Presentation.ValidationServices;
using ComputerGames.Presentation.ValidationServices.Interfaces;
using ComputerGames.Presentation.ViewModels;

namespace ComputerGames
{
    class Program
    {
        static void Main(string[] args)
        {
            IGameValidationService gamePresentationLayer = new GameValidationService();
            IGenreValidationService genrePresentationLayer = new GenreValidationService();
            IPublisherValidationService publisherPresentationLayer = new PublisherValidationService();

            var genre1Id = genrePresentationLayer.Create(new CreateGenreViewModel()
            {
                Description = "Genre 1"
            });

            var publisher1Id = publisherPresentationLayer.Create(new CreatePublisherViewModel()
            {
                Name = "Publisher 1",
                LicenceNumber = 1
            });

            gamePresentationLayer.Create(new CreateGameViewModel()
            {
                Name = "Game 1",
                ReleaseDate = new DateTime(2010, 1, 1),
                GenreId = genre1Id,
                PublisherId = publisher1Id
            });
        }
    }
}
