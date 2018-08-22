
using System.Collections.Generic;
using System.Threading.Tasks;
using SITA_MultiProject16.Entities;

namespace SITA_MultiProject16.BusinessAgent.Interface
{
	/// <summary>
    /// Interface to define Methods available for Airport
    /// </summary>
    public interface IAirportManager
    {
        Task CreateAirport(Airport entity);
        //Task<Airport> GetAirport(string id);
        Task<IList<Airport>> GetAllAirport();
        Task<bool> DeleteAirport(string id);
        Task<bool> UpdateAirport(string id, Airport updatedAirport);
    }
}