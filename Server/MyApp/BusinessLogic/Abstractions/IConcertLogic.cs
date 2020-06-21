using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Abstractions
{
    public interface IConcertLogic
    {
        ICollection<ConcertDto> GetAll();
        ConcertDto GetById(Guid id);
        ConcertDto AddConcert(ConcertDto concertDto);

    }
}
