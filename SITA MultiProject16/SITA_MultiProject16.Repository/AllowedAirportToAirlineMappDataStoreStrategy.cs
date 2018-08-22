
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.Helpers;
using SITA_MultiProject16.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Repository
{
    /// <summary>
    /// Repository Class to handle DB requests for AllowedAirportToAirlineMapp Type 
    /// </summary>
    public class AllowedAirportToAirlineMappDataStoreStrategy : BaseRepository<AllowedAirportToAirlineMapp>
    {
        #region Private Member
        ModelMapper<AllowedAirportToAirlineMapp, Entities.AllowedAirportToAirlineMapp> mapper;
        ModelMapper<IList<AllowedAirportToAirlineMapp>, IList<Entities.AllowedAirportToAirlineMapp>> listMapper;
        #endregion

        #region Ctor
        public AllowedAirportToAirlineMappDataStoreStrategy()
        {
            mapper = new ModelMapper<AllowedAirportToAirlineMapp, Entities.AllowedAirportToAirlineMapp>();
            listMapper = new ModelMapper<IList<AllowedAirportToAirlineMapp>, IList<Entities.AllowedAirportToAirlineMapp>>();
        }
        #endregion

        #region DB Interaction Methods

        /// <summary>
        /// Inheriting the Generic Create Method for Adding Data to DB
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task CreateAllowedAirportToAirlineMapp(AllowedAirportToAirlineMapp entity)
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
        public async Task<bool> DeleteAllowedAirportToAirlineMapp(string id)
        {
            try
            {
                return await Delete(id, typeof(AllowedAirportToAirlineMapp));
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
        public async Task<IList<AllowedAirportToAirlineMapp>> GetAllAllowedAirportToAirlineMapp()
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
        public async Task<AllowedAirportToAirlineMapp> GetAllowedAirportToAirlineMapp(string id)
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
        public async Task<bool> UpdateAllowedAirportToAirlineMapp(string id, AllowedAirportToAirlineMapp data)
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