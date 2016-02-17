using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.Infrastructure
{
    public class DependencyUnityResolver : IDependencyResolver
    {

        private IUnityContainer _unityContainer;

        public DependencyUnityResolver(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
        }

        /// <summary>
        /// It use to return service and if it wont find service it will returns null
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public object GetService(Type serviceType)
        {
            try
            {
                return _unityContainer.Resolve(serviceType);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _unityContainer.ResolveAll(serviceType);
            }
            catch (Exception)
            {

                return new List<object>();
            }
        }
    }
}