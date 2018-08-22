
using SITA_MultiProject16.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Repository.Interface
{
    /// <summary>
    /// Interface for Defining Actions possible against AssignedAirportToAirlineMapp Type at the DB level
    /// </summary>
    public interface IAssignedAirportToAirlineMappDataStoreStrategy
    {
        Task<AssignedAirportToAirlineMapp> GetAssignedAirportToAirlineMapp(string id);
        Task<IList<AssignedAirportToAirlineMapp>> GetAllAssignedAirportToAirlineMapp();
        Task CreateAssignedAirportToAirlineMapp(AssignedAirportToAirlineMapp entity);
        Task<bool> DeleteAssignedAirportToAirlineMapp(string id);
        Task<bool> UpdateAssignedAirportToAirlineMapp(string id, AssignedAirportToAirlineMapp data);
    }
}