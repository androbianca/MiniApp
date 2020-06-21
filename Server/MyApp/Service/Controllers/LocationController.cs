using BusinessLogic.Abstractions;
using Microsoft.AspNetCore.Mvc;

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

    }
}
