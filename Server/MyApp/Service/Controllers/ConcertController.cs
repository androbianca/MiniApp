﻿using System;
using System.Collections.Generic;
using BusinessLogic.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Service.Controllers
{

    [Route("api/concert")]
    [ApiController]
    public class ConcertController : ControllerBase
    {

        private readonly IConcertLogic _concertLogic;

        public ConcertController(IConcertLogic concertLogic)
        {
            _concertLogic = concertLogic;
        }

        [HttpPost]
        public void AddConcert(ConcertDto concertDto)
        {
            _concertLogic.AddConcert(concertDto);
        }


        [HttpGet]
        public ActionResult<ICollection<ConcertDto>> GetAll()
        {
            var concerts = _concertLogic.GetAll();

            return Ok(concerts);
        }

        [HttpGet("{id:guid}")]
        public ActionResult<ConcertDto> GetById([FromRoute] string id)
        {
            var concert = _concertLogic.GetById(id);

            if(concert == null)
            {
                return NotFound();
            }

            return Ok(concert);

        }

    }
}
