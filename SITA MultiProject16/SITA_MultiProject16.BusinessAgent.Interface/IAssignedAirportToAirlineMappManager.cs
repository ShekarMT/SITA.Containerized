
using System.Collections.Generic;
using System.Threading.Tasks;
using SITA_MultiProject16.Entities;

namespace SITA_MultiProject16.BusinessAgent.Interface
{
	/// <summary>
    /// Interface to define Methods available for AssignedAirportToAirlineMapp
    /// </summary>
    public interface IAssignedAirportToAirlineMappManager
    {
        Task CreateAssignedAirportToAirlineMapp(AssignedAirportToAirlineMapp entity);
        //Task<AssignedAirportToAirlineMapp> GetAssignedAirportToAirlineMapp(string id);
        Task<IList<AssignedAirportToAirlineMapp>> GetAllAssignedAirportToAirlineMapp();
        Task<bool> DeleteAssignedAirportToAirlineMapp(string id);
        Task<bool> UpdateAssignedAirportToAirlineMapp(string id, AssignedAirportToAirlineMapp updatedAssignedAirportToAirlineMapp);
    }
}