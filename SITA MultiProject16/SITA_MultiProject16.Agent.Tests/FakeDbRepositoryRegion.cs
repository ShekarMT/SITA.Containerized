
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Agent.Tests
{
	public class FakeDbRepositoryRegion : IBaseRepository<Region>
    {

        Task IBaseRepository<Region>.Create(Region entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(Region entity)
        {
            if (entity.Id != null && entity.Id != 0)
                return true;
            return false;
        }

        public async Task<bool> Delete(string id, Type type)
        {
            if ((string.IsNullOrEmpty(id) && string.IsNullOrWhiteSpace(id)) || id == "")
                return false;
            else
                return true;
        }


        public Task<Region> Get(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Region>> GetAll(params Expression<Func<Region, bool>>[] navigationProperties)
        {
                if (navigationProperties.Count() > 0)
                {
                    return new List<Region>()
					{
						new Region
						{

						},
						new Region
						{

						}
					};
                }
                return null;
        }

        public Task<bool> Update(string id, Region data)
        {
            if ((!string.IsNullOrEmpty(id) && !string.IsNullOrWhiteSpace(id) && data != null) && data.Id != 0)
                return Task.FromResult(true);
            return Task.FromResult(false);
        }

        
    }
}