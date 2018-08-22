
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.Helpers;
using SITA_MultiProject16.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Repository
{
    /// <summary>
    /// Repository Class to handle DB requests for Region Type 
    /// </summary>
    public class RegionDataStoreStrategy : BaseRepository<Region>
    {
        #region Private Member
        ModelMapper<Region, Entities.Region> mapper;
        ModelMapper<IList<Region>, IList<Entities.Region>> listMapper;
        #endregion

        #region Ctor
        public RegionDataStoreStrategy()
        {
            mapper = new ModelMapper<Region, Entities.Region>();
            listMapper = new ModelMapper<IList<Region>, IList<Entities.Region>>();
        }
        #endregion

        #region DB Interaction Methods

        /// <summary>
        /// Inheriting the Generic Create Method for Adding Data to DB
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task CreateRegion(Region entity)
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
        public async Task<bool> DeleteRegion(string id)
        {
            try
            {
                return await Delete(id, typeof(Region));
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
        public async Task<IList<Region>> GetAllRegion()
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
        public async Task<Region> GetRegion(string id)
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
        public async Task<bool> UpdateRegion(string id, Region data)
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