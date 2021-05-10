namespace API.Maintenance.Controllers
{
    using System.Threading.Tasks;
    using Application.Fleet.GetAll;
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class FleetController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FleetController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(AllAircraftResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllAircraft()
        {
            var result = await _mediator.Send(new GetAllAircraft());

            return Ok(result);
        }
    }
}
