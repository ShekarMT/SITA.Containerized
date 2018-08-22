
using System.Collections.Generic;
using System.Threading.Tasks;
using SITA_MultiProject16.Entities;

namespace SITA_MultiProject16.BusinessAgent.Interface
{
	/// <summary>
    /// Interface to define Methods available for Airline
    /// </summary>
    public interface IAirlineManager
    {
        Task CreateAirline(Airline entity);
        //Task<Airline> GetAirline(string id);
        Task<IList<Airline>> GetAllAirline();
        Task<bool> DeleteAirline(string id);
        Task<bool> UpdateAirline(string id, Airline updatedAirline);
    }
}