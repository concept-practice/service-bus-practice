namespace API.Maintenance.Application.Fleet.AircraftCommon
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain;

    public class AircraftRepository : IAircraftRepository
    {
        private readonly List<Aircraft> _aircraft;

        public AircraftRepository()
        {
            _aircraft = new List<Aircraft>();
        }

        public Task AddAircraft(Aircraft aircraft)
        {
            _aircraft.Add(aircraft);

            return Task.CompletedTask;
        }

        public Task<IReadOnlyList<Aircraft>> GetAllAircraft()
        {
            IReadOnlyList<Aircraft> result = _aircraft;

            return Task.FromResult(result);
        }
    }
}
