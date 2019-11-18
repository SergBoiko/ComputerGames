using ComputerGames.Core.Models;
using ComputerGames.Core.Requests;
using ComputerGames.Core.Services.Interfaces;
using ComputerGames.Dal.Entites;
using ComputerGames.Dal.Repositories;
using ComputerGames.Dal.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace ComputerGames.Core.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherRepository publisherRepository;

        public PublisherService()
        {
            this.publisherRepository = new PublisherRepository();
        }

        public int Create(CreatePublisherRequest request)
        {
            var publisherEntity = new PublisherEntity()
            {
                LicenceNumber = request.LicenceNumber,
                Name = request.Name
            };

            publisherRepository.Create(publisherEntity);

            return publisherEntity.Id;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Publisher> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Publisher model)
        {
            throw new NotImplementedException();
        }
    }
}
