using System.Web.Mvc;
using Bookstore.Web.Books;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace Bookstore.Web
{
    public static class Bootstrapper
    {
        public static void Initialize()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IBooks, BooksClient>(new HierarchicalLifetimeManager(), new InjectionConstructor());

            return container;
        }
    }
}