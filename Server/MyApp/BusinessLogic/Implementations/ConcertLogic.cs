using BusinessLogic.Abstractions;
using DataAccess.Abstractions;
using Entities;
using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Implementations
{
    public class ConcertLogic : BaseLogic, IConcertLogic
    {

        public ConcertLogic(IRepository repository)
     : base(repository)
        {
        }
        public ConcertDto AddConcert(ConcertDto concertDto)
        {
            var concert = new Concert
            {
                Id = Guid.NewGuid(),
                LocationId = Guid.Empty,
                Price = concertDto.Price,
            };

            _repository.Insert(concert);

            return null;
        }

        public ICollection<ConcertDto> GetAll()
        {
            var result = _repository.GetAll<Concert>();

            return null;
        }

        public ConcertDto GetById(Guid id)
        {
            var result = _repository.GetByFilter<Concert>(x => x.Id == id);

            return null;
        }
    }
}
