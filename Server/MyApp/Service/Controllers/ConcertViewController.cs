using System.Collections.Generic;
using BusinessLogic.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Service.Controllers
{

    [Route("api/concertView")]
    [ApiController]
    public class ConcertViewController : ControllerBase
    {

        private readonly IConcertViewLogic _concertViewLogic;

        public ConcertViewController(IConcertViewLogic concertViewLogic)
        {
            _concertViewLogic = concertViewLogic;
        }


        [HttpGet]
        public ActionResult<ICollection<ConcertViewDto>> GetAll()
        {
            var concerts = _concertViewLogic.GetAll();

            return Ok(concerts);
        }
    }
}
