
using System.Collections.Generic;
using System.Threading.Tasks;
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.BusinessAgent.Interface;
using SITA_MultiProject16.Helpers;
using SITA_MultiProject16.Repository;

namespace SITA_MultiProject16.BusinessAgent
{
	/// <summary>
    /// Business Agent for AssignedAirportToAirlineMapp Component
    /// </summary>
	public class AssignedAirportToAirlineMappManager : IAssignedAirportToAirlineMappManager
	{
		#region Private Members
		AssignedAirportToAirlineMappDataStoreStrategy _AssignedAirportToAirlineMappStore;
		ModelMapper<SITA_MultiProject16.Repository.AssignedAirportToAirlineMapp,Entities.AssignedAirportToAirlineMapp> mapper;
		ModelMapper<IList<SITA_MultiProject16.Repository.AssignedAirportToAirlineMapp>,IList<Entities.AssignedAirportToAirlineMapp>> listMapper;
		#endregion

		#region Ctor
        public AssignedAirportToAirlineMappManager()
        {
            _AssignedAirportToAirlineMappStore = new AssignedAirportToAirlineMappDataStoreStrategy();
            mapper = new ModelMapper<SITA_MultiProject16.Repository.AssignedAirportToAirlineMapp,Entities.AssignedAirportToAirlineMapp>();
            listMapper = new ModelMapper<IList<SITA_MultiProject16.Repository.AssignedAirportToAirlineMapp>,IList<Entities.AssignedAirportToAirlineMapp>>();
        }
        #endregion

		#region Business Methods

        /// <summary>
        /// Creates a new AssignedAirportToAirlineMapp Type record 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task CreateAssignedAirportToAirlineMapp(Entities.AssignedAirportToAirlineMapp entity)
        {
            await _AssignedAirportToAirlineMappStore.CreateAssignedAirportToAirlineMapp(mapper.ConvertModelToRepo(entity).Result);
        }

        /// <summary>
        /// Deletes an existing AssignedAirportToAirlineMapp Record according to ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAssignedAirportToAirlineMapp(string id)
        {
            return await _AssignedAirportToAirlineMappStore.DeleteAssignedAirportToAirlineMapp(id);
        }

        /// <summary>
        /// Fetches All AssignedAirportToAirlineMapp Records from the DB
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Entities.AssignedAirportToAirlineMapp>> GetAllAssignedAirportToAirlineMapp()
        {
            return await listMapper.ConvertRepoToApp( _AssignedAirportToAirlineMappStore.GetAllAssignedAirportToAirlineMapp().Result);
        }

        
        /// <summary>
        /// Updates an Existing AssignedAirportToAirlineMapp record with a changed data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedAssignedAirportToAirlineMapp"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAssignedAirportToAirlineMapp(string id, Entities.AssignedAirportToAirlineMapp updatedAssignedAirportToAirlineMapp)
        {
            return await _AssignedAirportToAirlineMappStore.UpdateAssignedAirportToAirlineMapp(id,mapper.ConvertModelToRepo(updatedAssignedAirportToAirlineMapp).Result);
        }

        #endregion
	}
}