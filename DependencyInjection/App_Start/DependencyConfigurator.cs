using DependencyInjection.Infrastructure;
using DependencyInjection.Service;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.App_Start
{
    public static class DependencyConfigurator
    {
        public static void ConfigureUnityservice()
        {
            IUnityContainer container = new UnityContainer();
            RegisterService(container);
            DependencyResolver.SetResolver(new DependencyUnityResolver(container));

        }

        /// <summary>
        /// Registering the service that you want to pull
        /// </summary>
        /// <param name="container"></param>
        private static void RegisterService(IUnityContainer container)
        {
            container.RegisterType<ILogger, LoggingErrorinFile>();
        }

    }
}