using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, Func<object>> Services = new Dictionary<Type, Func<object>>();

        public static void Register<T>(Func<T> factory)
        {
            Services[typeof(T)] = () => factory();
        }

        public static T GetInstance<T>()
        {
            if (Services.TryGetValue(typeof(T), out Func<object> factory))
            {
                return (T)factory();
            }
            throw new InvalidOperationException($"Service of type {typeof(T)} is not registered.");
        }
    }

}