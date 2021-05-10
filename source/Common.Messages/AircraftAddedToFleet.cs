using NServiceBus;
using System;

namespace Common.Messages
{
    public class AircraftAddedToFleet : IEvent
    {
        public AircraftAddedToFleet(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
