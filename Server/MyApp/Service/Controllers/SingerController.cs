using BusinessLogic.Abstractions;
using Microsoft.AspNetCore.Mvc;

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
    }
}
