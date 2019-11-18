using ComputerGames.Presentation.ViewModels;

namespace ComputerGames.Presentation.ValidationServices.Interfaces
{
    public interface IPublisherValidationService
    {
        int Create(CreatePublisherViewModel createPublisherViewModel);
    }
}
