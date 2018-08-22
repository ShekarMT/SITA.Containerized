
using System.Collections.Generic;
using System.Threading.Tasks;
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.BusinessAgent.Interface;
using SITA_MultiProject16.Helpers;
using SITA_MultiProject16.Repository;

namespace SITA_MultiProject16.BusinessAgent
{
	/// <summary>
    /// Business Agent for Airport Component
    /// </summary>
	public class AirportManager : IAirportManager
	{
		#region Private Members
		AirportDataStoreStrategy _AirportStore;
		ModelMapper<SITA_MultiProject16.Repository.Airport,Entities.Airport> mapper;
		ModelMapper<IList<SITA_MultiProject16.Repository.Airport>,IList<Entities.Airport>> listMapper;
		#endregion

		#region Ctor
        public AirportManager()
        {
            _AirportStore = new AirportDataStoreStrategy();
            mapper = new ModelMapper<SITA_MultiProject16.Repository.Airport,Entities.Airport>();
            listMapper = new ModelMapper<IList<SITA_MultiProject16.Repository.Airport>,IList<Entities.Airport>>();
        }
        #endregion

		#region Business Methods

        /// <summary>
        /// Creates a new Airport Type record 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task CreateAirport(Entities.Airport entity)
        {
            await _AirportStore.CreateAirport(mapper.ConvertModelToRepo(entity).Result);
        }

        /// <summary>
        /// Deletes an existing Airport Record according to ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAirport(string id)
        {
            return await _AirportStore.DeleteAirport(id);
        }

        /// <summary>
        /// Fetches All Airport Records from the DB
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Entities.Airport>> GetAllAirport()
        {
            return await listMapper.ConvertRepoToApp( _AirportStore.GetAllAirport().Result);
        }

        
        /// <summary>
        /// Updates an Existing Airport record with a changed data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedAirport"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAirport(string id, Entities.Airport updatedAirport)
        {
            return await _AirportStore.UpdateAirport(id,mapper.ConvertModelToRepo(updatedAirport).Result);
        }

        #endregion
	}
}