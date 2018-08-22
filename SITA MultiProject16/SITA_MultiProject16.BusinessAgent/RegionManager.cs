
using System.Collections.Generic;
using System.Threading.Tasks;
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.BusinessAgent.Interface;
using SITA_MultiProject16.Helpers;
using SITA_MultiProject16.Repository;

namespace SITA_MultiProject16.BusinessAgent
{
	/// <summary>
    /// Business Agent for Region Component
    /// </summary>
	public class RegionManager : IRegionManager
	{
		#region Private Members
		RegionDataStoreStrategy _RegionStore;
		ModelMapper<SITA_MultiProject16.Repository.Region,Entities.Region> mapper;
		ModelMapper<IList<SITA_MultiProject16.Repository.Region>,IList<Entities.Region>> listMapper;
		#endregion

		#region Ctor
        public RegionManager()
        {
            _RegionStore = new RegionDataStoreStrategy();
            mapper = new ModelMapper<SITA_MultiProject16.Repository.Region,Entities.Region>();
            listMapper = new ModelMapper<IList<SITA_MultiProject16.Repository.Region>,IList<Entities.Region>>();
        }
        #endregion

		#region Business Methods

        /// <summary>
        /// Creates a new Region Type record 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task CreateRegion(Entities.Region entity)
        {
            await _RegionStore.CreateRegion(mapper.ConvertModelToRepo(entity).Result);
        }

        /// <summary>
        /// Deletes an existing Region Record according to ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteRegion(string id)
        {
            return await _RegionStore.DeleteRegion(id);
        }

        /// <summary>
        /// Fetches All Region Records from the DB
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Entities.Region>> GetAllRegion()
        {
            return await listMapper.ConvertRepoToApp( _RegionStore.GetAllRegion().Result);
        }

        
        /// <summary>
        /// Updates an Existing Region record with a changed data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedRegion"></param>
        /// <returns></returns>
        public async Task<bool> UpdateRegion(string id, Entities.Region updatedRegion)
        {
            return await _RegionStore.UpdateRegion(id,mapper.ConvertModelToRepo(updatedRegion).Result);
        }

        #endregion
	}
}