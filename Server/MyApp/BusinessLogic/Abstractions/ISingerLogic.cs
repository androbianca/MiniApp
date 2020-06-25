
using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Abstractions
{
    public interface ISingerLogic
    {
        ICollection<SingerDto> GetAll();
        SingerDto GetById(Guid id);
        SingerDto AddSinger(SingerDto singerDto);
    }
}
