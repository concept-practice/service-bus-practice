namespace Fleet.API.Application.AddToFleet
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Common.Messages;
    using MediatR;
    using NServiceBus;

    public class AddAircraftToFleetHandler : IRequestHandler<AddAircraftToFleet>
    {
        private readonly IMessageSession _messageSession;

        public AddAircraftToFleetHandler(IMessageSession messageSession)
        {
            _messageSession = messageSession;
        }

        public async Task<Unit> Handle(AddAircraftToFleet request, CancellationToken cancellationToken)
        {
            await _messageSession.Publish(new AircraftAddedToFleet(Guid.NewGuid()));

            return Unit.Value;
        }
    }
}
