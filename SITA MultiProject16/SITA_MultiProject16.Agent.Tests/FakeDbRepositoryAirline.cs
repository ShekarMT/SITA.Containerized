
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Agent.Tests
{
	public class FakeDbRepositoryAirline : IBaseRepository<Airline>
    {

        Task IBaseRepository<Airline>.Create(Airline entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(Airline entity)
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


        public Task<Airline> Get(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Airline>> GetAll(params Expression<Func<Airline, bool>>[] navigationProperties)
        {
                if (navigationProperties.Count() > 0)
                {
                    return new List<Airline>()
					{
						new Airline
						{

						},
						new Airline
						{

						}
					};
                }
                return null;
        }

        public Task<bool> Update(string id, Airline data)
        {
            if ((!string.IsNullOrEmpty(id) && !string.IsNullOrWhiteSpace(id) && data != null) && data.Id != 0)
                return Task.FromResult(true);
            return Task.FromResult(false);
        }

        
    }
}