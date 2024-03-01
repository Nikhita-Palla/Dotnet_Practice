using DependencyInjection.Models;
using DependencyInjection.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Web;

namespace DependencyInjection
{
    public static class DependencyResolver
    {
        private static readonly Dictionary<Type,Object> _services= new Dictionary<Type,Object>();

        public static void Register<TService,TImplementation>() where TImplementation : TService, new()
        {
            _services[typeof(TService)] = new TImplementation();
        }

        public static TService Resolve<TService>()
        {
            return (TService)_services[typeof(TService)];
        }
        
    }

}