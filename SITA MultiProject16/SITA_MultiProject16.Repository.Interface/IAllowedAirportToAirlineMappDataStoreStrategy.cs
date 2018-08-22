
using SITA_MultiProject16.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Repository.Interface
{
    /// <summary>
    /// Interface for Defining Actions possible against AllowedAirportToAirlineMapp Type at the DB level
    /// </summary>
    public interface IAllowedAirportToAirlineMappDataStoreStrategy
    {
        Task<AllowedAirportToAirlineMapp> GetAllowedAirportToAirlineMapp(string id);
        Task<IList<AllowedAirportToAirlineMapp>> GetAllAllowedAirportToAirlineMapp();
        Task CreateAllowedAirportToAirlineMapp(AllowedAirportToAirlineMapp entity);
        Task<bool> DeleteAllowedAirportToAirlineMapp(string id);
        Task<bool> UpdateAllowedAirportToAirlineMapp(string id, AllowedAirportToAirlineMapp data);
    }
}