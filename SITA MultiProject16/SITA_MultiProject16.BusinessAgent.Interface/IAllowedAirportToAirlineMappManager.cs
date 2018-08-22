
using System.Collections.Generic;
using System.Threading.Tasks;
using SITA_MultiProject16.Entities;

namespace SITA_MultiProject16.BusinessAgent.Interface
{
	/// <summary>
    /// Interface to define Methods available for AllowedAirportToAirlineMapp
    /// </summary>
    public interface IAllowedAirportToAirlineMappManager
    {
        Task CreateAllowedAirportToAirlineMapp(AllowedAirportToAirlineMapp entity);
        //Task<AllowedAirportToAirlineMapp> GetAllowedAirportToAirlineMapp(string id);
        Task<IList<AllowedAirportToAirlineMapp>> GetAllAllowedAirportToAirlineMapp();
        Task<bool> DeleteAllowedAirportToAirlineMapp(string id);
        Task<bool> UpdateAllowedAirportToAirlineMapp(string id, AllowedAirportToAirlineMapp updatedAllowedAirportToAirlineMapp);
    }
}