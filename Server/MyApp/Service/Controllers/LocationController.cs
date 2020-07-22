using BusinessLogic.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;

namespace Service.Controllers
{

    [Route("api/location")]
    [ApiController]
    public class LocationController : ControllerBase
    {

        private readonly ILocationLogic _locationLogic;

        public LocationController(ILocationLogic locationLogic)
        {
            _locationLogic = locationLogic;
        }

        [HttpPost]
        public ActionResult<LocationDto> Addlocation(LocationDto location)
        {
            var result = _locationLogic.AddLocation(location);

            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }

            return Ok(result);
        }


        [HttpGet]
        public ActionResult<ICollection<LocationDto>> GetAll()
        {
            var locations = _locationLogic.GetAll();

            return Ok(locations);
        }

        [HttpGet("{id}")]
        public ActionResult<LocationDto> GetById([FromRoute] Guid id)
        {
            if (id != null)
            {
                var location = _locationLogic.GetById(id);

                if (location == null)
                {
                    return NotFound();
                }

                return Ok(location);

            }
            return NotFound();
        }

    }
}
