using Models;
using System.Collections.Generic;

namespace BusinessLogic.Abstractions
{
    public interface IConcertViewLogic
    {
        ICollection<ConcertViewDto> GetAll();
    }
}
