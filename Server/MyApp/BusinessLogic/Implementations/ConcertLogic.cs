using BusinessLogic.Abstractions;
using DataAccess.Abstractions;
using DataAccess.Implementations;
using Entities;
using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Implementations
{
    public class ConcertLogic : BaseLogic, IConcertLogic
    {
        public readonly IConcertSingerLogic _concertSingerLogic;
        public ConcertLogic(IUnitOfWork unitOfWork, IConcertSingerLogic concertSingerLogic)
     : base(unitOfWork)
        {
            _concertSingerLogic = concertSingerLogic;
        }
        public ConcertDto AddConcert(ConcertDto concertDto)
        {
            var concert = new Concert
            {
                Id = Guid.NewGuid(),
                Name = concertDto.Name,
                LocationId = concertDto.LocationId,
                Price = concertDto.Price,
            };

            _unitOfWork.ConcertRepository.Insert(concert);
            _unitOfWork.Commit();

            var concertSinger = new ConcertSingerDto
            {
                SingerId = concertDto.SingerId,
                ConcertId = concert.Id

            };
            _concertSingerLogic.AddConcertSinger(concertSinger);

            concertDto.Id = concert.Id;
            return concertDto;
        }

        public ICollection<ConcertDto> GetAll()
        {
            var concerts = _unitOfWork.ConcertRepository.GetAll<Concert>();

            var concertDtos = new List<ConcertDto>();

            foreach (var concert in concerts)
            {

                var concertDto = new ConcertDto
                {
                    Id = concert.Id,
                    Name = concert.Name,
                    LocationId = concert.LocationId,
                    Price = concert.Price,
                };

                concertDtos.Add(concertDto);
            }

            return concertDtos;
        }

        public ConcertDto GetById(Guid id)
        {
            var concert = _unitOfWork.ConcertRepository.GetByFilter<Concert>(x => x.Id == id);

            if (concert == null)
            {
                return null;
            }

            var concertDto = new ConcertDto
            {
                Id = concert.Id,
                Name = concert.Name,
                LocationId = concert.LocationId,
                Price = concert.Price,
            };

            return concertDto;
        }
    }
}
