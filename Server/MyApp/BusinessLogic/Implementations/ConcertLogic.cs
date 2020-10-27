using BusinessLogic.Abstractions;
using DataAccess.Abstractions;
using DataAccess.Implementations;
using Entities;
using Microsoft.Extensions.Logging;
using Models;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Implementations
{
    public class ConcertLogic : BaseLogic, IConcertLogic
    {
        public readonly IConcertSingerLogic _concertSingerLogic;
        private readonly ILogger<ConcertLogic> _logger;

        public ConcertLogic(IUnitOfWork unitOfWork, IConcertSingerLogic concertSingerLogic, ILogger<ConcertLogic> logger)
     : base(unitOfWork)
        {
            _concertSingerLogic = concertSingerLogic;
            _logger = logger;
        }
        public ConcertDto AddConcert(ConcertDto concertDto)
        {
            var concert = new Concert
            {
                Id = Guid.Parse("72df89e3-cc62-4882-bfab-a399557e6b55"),
                Name = concertDto.Name,
                LocationId = concertDto.LocationId,
                Price = concertDto.Price,
            };

            var concertSinger = new ConcertSingerDto
            {
                SingerId = concertDto.SingerId,
                ConcertId = concert.Id

            };

            try
            {
                _unitOfWork.ConcertRepository.Insert(concert);
                _unitOfWork.Commit();
            }

            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
            }

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
