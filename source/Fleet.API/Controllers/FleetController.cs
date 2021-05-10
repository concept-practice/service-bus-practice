namespace Fleet.API.Controllers
{
    using System.Threading.Tasks;
    using Application.AddToFleet;
    using MediatR;
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

        [HttpPost]
        public async Task<IActionResult> AddAircraftToFleet(AddAircraftToFleet request)
        {
            await _mediator.Send(request);

            return Created(string.Empty, null);
        }
    }
}
