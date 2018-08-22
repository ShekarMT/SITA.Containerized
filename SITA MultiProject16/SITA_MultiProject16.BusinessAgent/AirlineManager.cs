
using System.Collections.Generic;
using System.Threading.Tasks;
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.BusinessAgent.Interface;
using SITA_MultiProject16.Helpers;
using SITA_MultiProject16.Repository;

namespace SITA_MultiProject16.BusinessAgent
{
	/// <summary>
    /// Business Agent for Airline Component
    /// </summary>
	public class AirlineManager : IAirlineManager
	{
		#region Private Members
		AirlineDataStoreStrategy _AirlineStore;
		ModelMapper<SITA_MultiProject16.Repository.Airline,Entities.Airline> mapper;
		ModelMapper<IList<SITA_MultiProject16.Repository.Airline>,IList<Entities.Airline>> listMapper;
		#endregion

		#region Ctor
        public AirlineManager()
        {
            _AirlineStore = new AirlineDataStoreStrategy();
            mapper = new ModelMapper<SITA_MultiProject16.Repository.Airline,Entities.Airline>();
            listMapper = new ModelMapper<IList<SITA_MultiProject16.Repository.Airline>,IList<Entities.Airline>>();
        }
        #endregion

		#region Business Methods

        /// <summary>
        /// Creates a new Airline Type record 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task CreateAirline(Entities.Airline entity)
        {
            await _AirlineStore.CreateAirline(mapper.ConvertModelToRepo(entity).Result);
        }

        /// <summary>
        /// Deletes an existing Airline Record according to ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAirline(string id)
        {
            return await _AirlineStore.DeleteAirline(id);
        }

        /// <summary>
        /// Fetches All Airline Records from the DB
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Entities.Airline>> GetAllAirline()
        {
            return await listMapper.ConvertRepoToApp( _AirlineStore.GetAllAirline().Result);
        }

        
        /// <summary>
        /// Updates an Existing Airline record with a changed data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedAirline"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAirline(string id, Entities.Airline updatedAirline)
        {
            return await _AirlineStore.UpdateAirline(id,mapper.ConvertModelToRepo(updatedAirline).Result);
        }

        #endregion
	}
}