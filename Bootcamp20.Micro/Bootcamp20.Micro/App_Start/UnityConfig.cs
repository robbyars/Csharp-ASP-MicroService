using System.Web.Mvc;
using Bootcamp20.Micro.BussinessLogic.Repository;
using Bootcamp20.Micro.BussinessLogic.Service;
using Bootcamp20.Micro.Common.Interfaces;
using Bootcamp20.Micro.Common.Interfaces.Application;
using Unity;
using Unity.Mvc5;

namespace Bootcamp20.Micro
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            //Service Tribe
            container.RegisterType<ISupplierService, SupplierService>();

            //Repository Tribe
            container.RegisterType<ISupplierRepository, SupplierRepository>();
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}