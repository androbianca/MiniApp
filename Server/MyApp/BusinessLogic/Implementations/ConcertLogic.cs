using BusinessLogic.Abstractions;
using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Implementations
{
    public class ConcertLogic : IConcertLogic
    {
        List<ConcertDto> concerts = new List<ConcertDto>() {
            new ConcertDto { Id ="6b7bc068-b27d-43d7-8b14-d85df717c197", Singer = "The Weekend", Price = 900, Location = "London" },
            new ConcertDto { Id = "d001b548-86ad-419d-91a4-81ece895bb7a", Singer = "Delia", Price = 700, Location = "Romania" },
            new ConcertDto { Id = "dfbaaf18-e7ed-46de-8ddc-d4e28a5e729d", Singer = "Rihanna", Price = 900, Location = "Paris" } };


        public void AddConcert(ConcertDto concertDto)
        {
            concerts.Add(concertDto);

        }

        public ICollection<ConcertDto> GetAll()
        {
            return concerts;
        }

        public ConcertDto GetById(string id)
        {
            var concert = concerts.Find(x => x.Id == id);

            return concert;
        }
    }
}
