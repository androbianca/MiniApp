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

        /*
          public ConcertDto AddConcert(ConcertDto concertDto)
          {
              var concert = new Concert
              {
                  Id = Guid.NewGuid().ToString(),
                  Singer = concertDto.Singer,
                  Price = concertDto.Price,
                  Location = concertDto.Location,
              };

              concerts.Add(concert);
              return concertDto;
          }

          public ICollection<ConcertDto> GetAll()
          {
              var concertDtos = new List<ConcertDto>();
              foreach (var concert in concerts)
              {
                  var concertDto = new ConcertDto
                  {
                      Singer = concert.Singer,
                      Price = concert.Price,
                      Location = concert.Location,
                  };
                  concertDtos.Add(concertDto);
              }

              return concertDtos;
          }

          public ConcertDto GetById(string id)
          {
              var concert = concerts.Find(x => x.Id == id);

              if (concert == null)
              {
                  return null;
              }
              var concertDto = new ConcertDto
              {
                  Singer = concert.Singer,
                  Price = concert.Price,
                  Location = concert.Location,
              };
              return concertDto;
          }*/
        public ConcertDto AddConcert(ConcertDto concertDto)
        {
            throw new NotImplementedException();
        }

        public ICollection<ConcertDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ConcertDto GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
