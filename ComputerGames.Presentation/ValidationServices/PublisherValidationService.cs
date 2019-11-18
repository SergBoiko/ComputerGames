using System;
using ComputerGames.Core.Requests;
using ComputerGames.Core.Services;
using ComputerGames.Core.Services.Interfaces;
using ComputerGames.Presentation.ValidationServices.Interfaces;
using ComputerGames.Presentation.ViewModels;

namespace ComputerGames.Presentation.ValidationServices
{
    public class PublisherValidationService : ValidationService, IPublisherValidationService
    {
        private readonly IPublisherService publisherService;

        public PublisherValidationService()
        {
            this.publisherService = new PublisherService();
        }

        public int Create(CreatePublisherViewModel createPublisherViewModel)
        {
            Validate(createPublisherViewModel);

            return publisherService.Create(new CreatePublisherRequest()
            {
                LicenceNumber = createPublisherViewModel.LicenceNumber,
                Name = createPublisherViewModel.Name
            });
        }
    }
}
