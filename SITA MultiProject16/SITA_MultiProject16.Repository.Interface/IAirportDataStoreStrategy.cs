
using SITA_MultiProject16.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Repository.Interface
{
    /// <summary>
    /// Interface for Defining Actions possible against Airport Type at the DB level
    /// </summary>
    public interface IAirportDataStoreStrategy
    {
        Task<Airport> GetAirport(string id);
        Task<IList<Airport>> GetAllAirport();
        Task CreateAirport(Airport entity);
        Task<bool> DeleteAirport(string id);
        Task<bool> UpdateAirport(string id, Airport data);
    }
}