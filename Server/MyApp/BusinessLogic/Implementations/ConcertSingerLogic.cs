using BusinessLogic.Abstractions;
using DataAccess.Abstractions;
using Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Implementations
{
    class ConcertSingerLogic : BaseLogic, IConcertSingerLogic
    {
        public ConcertSingerLogic(IUnitOfWork unitOfWork)
     : base(unitOfWork)
        {
        }
        public ConcertSingerDto AddConcertSinger(ConcertSingerDto concertSingerDto)
        {
            var concertSinger = new ConcertSinger
            {
                Id = Guid.NewGuid(),
                ConcertId = concertSingerDto.ConcertId,
                SingerId = concertSingerDto.SingerId,
            };

            _unitOfWork.ConcertSingerRepository.Insert(concertSinger);
            _unitOfWork.Commit();

            return concertSingerDto;
        }

        public ICollection<ConcertSingerDto> GetAll()
        {
            var concertSingers = _unitOfWork.ConcertRepository.GetAll<ConcertSinger>();

            var concertDtos = new List<ConcertSingerDto>();

            foreach (var concertSinger in concertSingers)
            {
                var concertSingerDto = new ConcertSingerDto
                {
                    SingerId = concertSinger.SingerId,
                    ConcertId = concertSinger.ConcertId
                };

                concertDtos.Add(concertSingerDto);
            }

            return concertDtos;
        }
    }
}
