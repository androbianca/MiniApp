using BusinessLogic.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;

namespace Service.Controllers
{

    [Route("api/singer")]
    [ApiController]
    public class SingerController : ControllerBase
    {

        private readonly ISingerLogic _singerLogic;

        public SingerController(ISingerLogic singerLogic)
        {
            _singerLogic = singerLogic;
        }

        [HttpPost]
        public ActionResult<SingerDto> AddSinger(SingerDto Singer)
        {
            var result = _singerLogic.AddSinger(Singer);

            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }

            return Ok(result);
        }


        [HttpGet]
        public ActionResult<ICollection<SingerDto>> GetAll()
        {
            var singers = _singerLogic.GetAll();

            return Ok(singers);
        }

        [HttpGet("{id}")]
        public ActionResult<SingerDto> GetById([FromRoute] Guid id)
        {
            if (id != null)
            {
                var singer = _singerLogic.GetById(id);

                if (singer == null)
                {
                    return NotFound();
                }

                return Ok(singer);

            }
            return NotFound();
        }

    }
}
