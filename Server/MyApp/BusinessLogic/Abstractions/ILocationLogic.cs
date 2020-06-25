using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Abstractions
{
    public interface ILocationLogic
    {
        ICollection<LocationDto> GetAll();
        LocationDto GetById(Guid id);
        LocationDto AddLocation(LocationDto locationDto);

    }
}
