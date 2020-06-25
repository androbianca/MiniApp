using BusinessLogic.Abstractions;
using DataAccess.Abstractions;
using Entities;
using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Implementations
{
    public class SingerLogic : BaseLogic, ISingerLogic
    {

        public SingerLogic(IUnitOfWork unitOfWork)
     : base(unitOfWork)
        {
        }

        public SingerDto AddSinger(SingerDto singerDto)
        {
            var singer = new Singer
            {
                Id = Guid.NewGuid(),
                Name = singerDto.Name,
                MusicType = singerDto.MusicType,
            };

            _unitOfWork.SingerRepository.Insert(singer);
            _unitOfWork.Commit();

            singerDto.Id = singer.Id;
           
            return singerDto;
        }

        public ICollection<SingerDto> GetAll()
        {
            var singers = _unitOfWork.SingerRepository.GetAll<Singer>();

            var singerDtos = new List<SingerDto>();

            foreach (var singer in singers)
            {

                var singerDto = new SingerDto
                {
                    Id = Guid.NewGuid(),
                    Name = singer.Name,
                    MusicType = singer.MusicType,
                };

                singerDtos.Add(singerDto);
            }

            return singerDtos;
        }

        public SingerDto GetById(Guid id)
        {
            var singer = _unitOfWork.SingerRepository.GetByFilter<Singer>(x => x.Id == id);

            var singerDto = new SingerDto
            {
                Id = singer.Id,
                Name = singer.Name,
                MusicType = singer.MusicType,
            };

            return singerDto;
        }


    }
}
