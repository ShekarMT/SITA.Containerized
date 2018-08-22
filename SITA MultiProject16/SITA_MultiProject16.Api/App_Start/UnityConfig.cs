
using System.Web.Http;
using Unity;
using Unity.WebApi;
using SITA_MultiProject16.Repository;
using SITA_MultiProject16.Repository.Interface;
using SITA_MultiProject16.BusinessAgent;
using SITA_MultiProject16.BusinessAgent.Interface;

namespace SITA_MultiProject16.Api.App_Start
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();
			
			//DI registration for Repository Classes and Agent Classes

						//container.RegisterType<IAirlineDataStoreStrategy,AirlineDataStoreStrategy>();

			container.RegisterType<IAirlineManager,AirlineManager>();
						//container.RegisterType<IAirportDataStoreStrategy,AirportDataStoreStrategy>();

			container.RegisterType<IAirportManager,AirportManager>();
						//container.RegisterType<IAllowedAirportToAirlineMappDataStoreStrategy,AllowedAirportToAirlineMappDataStoreStrategy>();

			container.RegisterType<IAllowedAirportToAirlineMappManager,AllowedAirportToAirlineMappManager>();
						//container.RegisterType<IAssignedAirportToAirlineMappDataStoreStrategy,AssignedAirportToAirlineMappDataStoreStrategy>();

			container.RegisterType<IAssignedAirportToAirlineMappManager,AssignedAirportToAirlineMappManager>();
						//container.RegisterType<IRegionDataStoreStrategy,RegionDataStoreStrategy>();

			container.RegisterType<IRegionManager,RegionManager>();
			
			GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
		}
	}
	
}