using System;
using System.Collections.Generic;
using BusinessLogic.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace Service.Controllers
{

    [Route("api/concert")]
    [ApiController]
    public class ConcertController : ControllerBase
    {
        private readonly ILogger<ConcertController> _logger;

        private readonly IConcertLogic _concertLogic;

        public ConcertController(IConcertLogic concertLogic, ILogger<ConcertController> logger)
        {
            _concertLogic = concertLogic;
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<ConcertDto> AddConcert(ConcertDto concertDto)
        {
            
             try
            {
                _concertLogic.AddConcert(concertDto);
            } catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            if (!ModelState.IsValid) 
            {
                return new BadRequestObjectResult(ModelState);
            }

            return Ok(concertDto);
        }


        [HttpGet]
        public ActionResult<ICollection<ConcertDto>> GetAll()
        {
            var concerts = _concertLogic.GetAll();



            return Ok(concerts);
        }

        [HttpGet("{id}")]
        public ActionResult<ConcertDto> GetById([FromRoute] Guid id)
        {
            if (id != null)
            {
                var concert = _concertLogic.GetById(id);

                if (concert == null)
                {
                    return NotFound();
                }

                return Ok(concert);

            }
            return NotFound();
        }

    }
}
