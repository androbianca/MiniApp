using BusinessLogic.Abstractions;
using DataAccess.Abstractions;
using Entities;
using Models;
using System.Collections.Generic;

namespace BusinessLogic.Implementations
{
     class ConcertViewLogic : BaseLogic, IConcertViewLogic
    {
        public ConcertViewLogic(IUnitOfWork unitOfWork)
     : base(unitOfWork)
        {
        }
 
      public ICollection<ConcertViewDto> GetAll()
        {
            var concertViews = _unitOfWork.ConcertViewRepository.GetAll<ConcertView>();
            var concertViewsDtos = new List<ConcertViewDto>();

            foreach ( var concertview in concertViews) {
               
                var concertViewDto = new ConcertViewDto
                {
                    ConcertName = concertview.ConcertName,
                    Price = concertview.Price,
                    LocationName = concertview.LocationName,
                    SingerName = concertview.SingerName
                };

                concertViewsDtos.Add(concertViewDto);
            }

            return concertViewsDtos;
        }
    }
}
