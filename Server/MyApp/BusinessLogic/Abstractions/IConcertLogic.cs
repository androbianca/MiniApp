using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Abstractions
{
    public interface IConcertLogic
    {
        ICollection<ConcertDto> GetAll();
        ConcertDto GetById(string id);
        void AddConcert(ConcertDto concertDto);

    }
}
