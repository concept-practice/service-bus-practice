namespace API.Maintenance.Application.Fleet.AircraftCommon
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain;

    public interface IAircraftRepository
    {
        Task AddAircraft(Aircraft aircraft);

        Task<IReadOnlyList<Aircraft>> GetAllAircraft();
    }
}
