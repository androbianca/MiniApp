using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Abstractions
{
    public interface IConcertSingerLogic
    {
        ICollection<ConcertSingerDto> GetAll();
        ConcertSingerDto AddConcertSinger(ConcertSingerDto concertSingerDto);

    }
}
