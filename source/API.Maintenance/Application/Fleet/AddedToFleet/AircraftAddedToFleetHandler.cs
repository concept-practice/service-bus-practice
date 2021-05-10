namespace API.Maintenance.Application.Fleet.AddedToFleet
{
    using System.Threading.Tasks;
    using AircraftCommon;
    using Common.Messages;
    using Domain;
    using NServiceBus;

    public class AircraftAddedToFleetHandler : IHandleMessages<AircraftAddedToFleet>
    {
        private readonly IAircraftRepository _aircraftRepository;

        public AircraftAddedToFleetHandler(IAircraftRepository aircraftRepository)
        {
            _aircraftRepository = aircraftRepository;
        }

        public async Task Handle(AircraftAddedToFleet message, IMessageHandlerContext context)
        {
            var aircraft = new Aircraft(message.Id);

            await _aircraftRepository.AddAircraft(aircraft);
        }
    }
}
