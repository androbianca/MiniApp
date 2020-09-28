using BusinessLogic.Abstractions;
using DataAccess.Abstractions;
using Entities;
using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Implementations
{
    public class LocationLogic : BaseLogic, ILocationLogic
    {

        public LocationLogic(IUnitOfWork unitOfWork)
     : base(unitOfWork)
        {
        }

        public LocationDto AddLocation(LocationDto locationDto)
        {
            var location = new Location
            {
                Id = Guid.NewGuid(),
                Country = locationDto.Country,
                County = locationDto.County,
                Name = locationDto.Name,
                Street = locationDto.Street,
                Latitude = locationDto.Latitude,
                Longitude = locationDto.Longitude
            };

            _unitOfWork.LocationRepository.Insert(location);
            _unitOfWork.Commit();

            locationDto.Id = location.Id;
            return locationDto;
        }

        public ICollection<LocationDto> GetAll()
        {
            var locationDtos = new List<LocationDto>();
            var result = _unitOfWork.LocationRepository.GetAll<Location>();

            foreach( var location in result) {

                var locationDto = new LocationDto
                {
                    Id = location.Id,
                    Country = location.Country,
                    County = location.County,
                    Name = location.Name,
                    Street = location.Street,
                    Latitude = location.Latitude,
                    Longitude = location.Longitude
            };

                locationDtos.Add(locationDto);
            }

            return locationDtos;
        }

        public LocationDto GetById(Guid id)
        {
            var location = _unitOfWork.LocationRepository.GetByFilter<Location>(x => x.Id == id);

            var locationDto = new LocationDto
            {
                Id = location.Id,
                Country = location.Country,
                County = location.County,
                Name = location.Name,
                Street = location.Street,
                Latitude = location.Latitude,
                Longitude = location.Longitude
            };

            return locationDto;
        }
    }
}
