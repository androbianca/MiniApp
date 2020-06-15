using BusinessLogic.Abstractions;
using Entities;
using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Implementations
{
    public class ConcertLogic : IConcertLogic
    {
        List<Concert> concerts = new List<Concert>() {
            new Concert { Id ="1", Singer = "The Weekend", Price = 900, Location = "London" },
            new Concert { Id = "2", Singer = "Delia", Price = 700, Location = "Romania" },
            new Concert { Id = "3", Singer = "Rihanna", Price = 900, Location = "Paris" } };


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
            foreach (var concert in concerts) {
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
        }
    }
}
