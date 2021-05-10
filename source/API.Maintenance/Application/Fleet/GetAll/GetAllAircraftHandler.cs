namespace API.Maintenance.Application.Fleet.GetAll
{
    using System.Threading;
    using System.Threading.Tasks;
    using AircraftCommon;
    using MediatR;

    public class GetAllAircraftHandler : IRequestHandler<GetAllAircraft, AllAircraftResponse>
    {
        private readonly IAircraftRepository _aircraftRepository;

        public GetAllAircraftHandler(IAircraftRepository aircraftRepository)
        {
            _aircraftRepository = aircraftRepository;
        }

        public async Task<AllAircraftResponse> Handle(GetAllAircraft request, CancellationToken cancellationToken)
        {
            var result = await _aircraftRepository.GetAllAircraft();

            return new AllAircraftResponse(result);
        }
    }
}
