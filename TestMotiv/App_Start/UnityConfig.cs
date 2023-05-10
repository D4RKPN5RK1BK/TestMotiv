using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;
using System.Web.Mvc;
using AutoMapper;
using TestMotiv.Abstractions;
using TestMotiv.Contexts;
using TestMotiv.Services;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace TestMotiv
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterSingleton<Mapper>(new InjectionConstructor(new MapperConfiguration(conf => conf.AddMaps(typeof(MvcApplication)))));
            container.RegisterSingleton<IPageDataService, PageDataService>();
            container.RegisterType<UserRequestContext>(new InjectionConstructor(WebConfigurationManager.ConnectionStrings["Default"].ConnectionString));

            foreach (var t in GetTypesByGenericInterface(typeof(IFilterHelper<,>)))
            {
                var interfaces = t.GetInterfaces();
                var serviceType = interfaces.First(i => i.GetGenericTypeDefinition() == typeof(IFilterHelper<,>));
                container.RegisterSingleton(serviceType, t);
            }
                
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        /// <summary>
        /// Получаем типы реализующие заданный Generic интерфейс
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static IEnumerable<Type> GetTypesByGenericInterface(Type type)
        {
           return System.Reflection.Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(item => item.GetInterfaces()
                    .Where(i => i.IsGenericType).Any(i => i.GetGenericTypeDefinition() == type) && !item.IsAbstract && !item.IsInterface);
        }
    }
}