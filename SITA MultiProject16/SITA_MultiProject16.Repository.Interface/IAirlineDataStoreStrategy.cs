
using SITA_MultiProject16.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Repository.Interface
{
    /// <summary>
    /// Interface for Defining Actions possible against Airline Type at the DB level
    /// </summary>
    public interface IAirlineDataStoreStrategy
    {
        Task<Airline> GetAirline(string id);
        Task<IList<Airline>> GetAllAirline();
        Task CreateAirline(Airline entity);
        Task<bool> DeleteAirline(string id);
        Task<bool> UpdateAirline(string id, Airline data);
    }
}