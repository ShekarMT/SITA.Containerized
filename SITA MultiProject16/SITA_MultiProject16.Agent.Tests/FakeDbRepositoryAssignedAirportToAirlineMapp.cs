
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Agent.Tests
{
	public class FakeDbRepositoryAssignedAirportToAirlineMapp : IBaseRepository<AssignedAirportToAirlineMapp>
    {

        Task IBaseRepository<AssignedAirportToAirlineMapp>.Create(AssignedAirportToAirlineMapp entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(AssignedAirportToAirlineMapp entity)
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


        public Task<AssignedAirportToAirlineMapp> Get(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<AssignedAirportToAirlineMapp>> GetAll(params Expression<Func<AssignedAirportToAirlineMapp, bool>>[] navigationProperties)
        {
                if (navigationProperties.Count() > 0)
                {
                    return new List<AssignedAirportToAirlineMapp>()
					{
						new AssignedAirportToAirlineMapp
						{

						},
						new AssignedAirportToAirlineMapp
						{

						}
					};
                }
                return null;
        }

        public Task<bool> Update(string id, AssignedAirportToAirlineMapp data)
        {
            if ((!string.IsNullOrEmpty(id) && !string.IsNullOrWhiteSpace(id) && data != null) && data.Id != 0)
                return Task.FromResult(true);
            return Task.FromResult(false);
        }

        
    }
}