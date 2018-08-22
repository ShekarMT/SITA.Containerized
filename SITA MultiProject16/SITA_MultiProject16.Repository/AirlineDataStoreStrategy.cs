
using SITA.NGP.Framework.Infra;
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.Helpers;
using SITA_MultiProject16.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Repository
{
    /// <summary>
    /// Repository Class to handle DB requests for Airline Type 
    /// </summary>
    public class AirlineDataStoreStrategy : BaseRepository<Airline>
    {
        #region Private Member
        ModelMapper<Airline, Entities.Airline> mapper;
        ModelMapper<IList<Airline>, IList<Entities.Airline>> listMapper;
        #endregion

        #region Ctor
        public AirlineDataStoreStrategy()
        {
            mapper = new ModelMapper<Airline, Entities.Airline>();
            listMapper = new ModelMapper<IList<Airline>, IList<Entities.Airline>>();
        }
        #endregion

        #region DB Interaction Methods

        /// <summary>
        /// Inheriting the Generic Create Method for Adding Data to DB
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        
        public async Task CreateAirline(Airline entity)
        {
            try
            {
                await Create(entity);
            }
            catch (Exception ex)
            {

            }
        }


        /// <summary>
        /// Inheriting the Generic Delete Method for Removing Data from DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAirline(string id)
        {
            try
            {
                return await Delete(id, typeof(Airline));
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Inheriting the Generic Get All Method for Retrieving All Data from DB
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Airline>> GetAllAirline()
        {
            try
            {
                return GetAll(d => d.Id != null).Result;
                
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Inheriting the Generic Get By Id Method for Retrieving Single Data from DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Airline> GetAirline(string id)
        {
        //    try
        //    {
        //        return await Get(id);
        //    }
        //    catch (Exception ex)
        //    {
                return null;
        //    }
        }

        /// <summary>
        /// Inheriting the Generic Update Method for Updating Single Data in DB
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAirline(string id, Airline data)
        {
            try
            {
                return await Update(id, data);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}