
using System.Collections.Generic;
using System.Threading.Tasks;
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.BusinessAgent.Interface;
using SITA_MultiProject16.Helpers;
using SITA_MultiProject16.Repository;

namespace SITA_MultiProject16.BusinessAgent
{
	/// <summary>
    /// Business Agent for AllowedAirportToAirlineMapp Component
    /// </summary>
	public class AllowedAirportToAirlineMappManager : IAllowedAirportToAirlineMappManager
	{
		#region Private Members
		AllowedAirportToAirlineMappDataStoreStrategy _AllowedAirportToAirlineMappStore;
		ModelMapper<SITA_MultiProject16.Repository.AllowedAirportToAirlineMapp,Entities.AllowedAirportToAirlineMapp> mapper;
		ModelMapper<IList<SITA_MultiProject16.Repository.AllowedAirportToAirlineMapp>,IList<Entities.AllowedAirportToAirlineMapp>> listMapper;
		#endregion

		#region Ctor
        public AllowedAirportToAirlineMappManager()
        {
            _AllowedAirportToAirlineMappStore = new AllowedAirportToAirlineMappDataStoreStrategy();
            mapper = new ModelMapper<SITA_MultiProject16.Repository.AllowedAirportToAirlineMapp,Entities.AllowedAirportToAirlineMapp>();
            listMapper = new ModelMapper<IList<SITA_MultiProject16.Repository.AllowedAirportToAirlineMapp>,IList<Entities.AllowedAirportToAirlineMapp>>();
        }
        #endregion

		#region Business Methods

        /// <summary>
        /// Creates a new AllowedAirportToAirlineMapp Type record 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task CreateAllowedAirportToAirlineMapp(Entities.AllowedAirportToAirlineMapp entity)
        {
            await _AllowedAirportToAirlineMappStore.CreateAllowedAirportToAirlineMapp(mapper.ConvertModelToRepo(entity).Result);
        }

        /// <summary>
        /// Deletes an existing AllowedAirportToAirlineMapp Record according to ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAllowedAirportToAirlineMapp(string id)
        {
            return await _AllowedAirportToAirlineMappStore.DeleteAllowedAirportToAirlineMapp(id);
        }

        /// <summary>
        /// Fetches All AllowedAirportToAirlineMapp Records from the DB
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Entities.AllowedAirportToAirlineMapp>> GetAllAllowedAirportToAirlineMapp()
        {
            return await listMapper.ConvertRepoToApp( _AllowedAirportToAirlineMappStore.GetAllAllowedAirportToAirlineMapp().Result);
        }

        
        /// <summary>
        /// Updates an Existing AllowedAirportToAirlineMapp record with a changed data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedAllowedAirportToAirlineMapp"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAllowedAirportToAirlineMapp(string id, Entities.AllowedAirportToAirlineMapp updatedAllowedAirportToAirlineMapp)
        {
            return await _AllowedAirportToAirlineMappStore.UpdateAllowedAirportToAirlineMapp(id,mapper.ConvertModelToRepo(updatedAllowedAirportToAirlineMapp).Result);
        }

        #endregion
	}
}