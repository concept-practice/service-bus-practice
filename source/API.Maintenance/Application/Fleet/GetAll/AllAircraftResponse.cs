namespace API.Maintenance.Application.Fleet.GetAll
{
    using System.Collections.Generic;
    using Domain;

    public class AllAircraftResponse
    {
        public AllAircraftResponse(IReadOnlyList<Aircraft> airplanes)
        {
            Airplanes = airplanes;
        }

        public IReadOnlyList<Aircraft> Airplanes { get; }
    }
}
