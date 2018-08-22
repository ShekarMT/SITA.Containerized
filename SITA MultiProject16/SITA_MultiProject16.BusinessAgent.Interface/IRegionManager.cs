
using System.Collections.Generic;
using System.Threading.Tasks;
using SITA_MultiProject16.Entities;

namespace SITA_MultiProject16.BusinessAgent.Interface
{
	/// <summary>
    /// Interface to define Methods available for Region
    /// </summary>
    public interface IRegionManager
    {
        Task CreateRegion(Region entity);
        //Task<Region> GetRegion(string id);
        Task<IList<Region>> GetAllRegion();
        Task<bool> DeleteRegion(string id);
        Task<bool> UpdateRegion(string id, Region updatedRegion);
    }
}