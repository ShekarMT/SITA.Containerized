
using SITA_MultiProject16.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Repository.Interface
{
    /// <summary>
    /// Interface for Defining Actions possible against Region Type at the DB level
    /// </summary>
    public interface IRegionDataStoreStrategy
    {
        Task<Region> GetRegion(string id);
        Task<IList<Region>> GetAllRegion();
        Task CreateRegion(Region entity);
        Task<bool> DeleteRegion(string id);
        Task<bool> UpdateRegion(string id, Region data);
    }
}