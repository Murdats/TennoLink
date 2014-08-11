using System;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using TennoLink.AppStart;
using TennoLink.Models;
using TennoLink.Models.Interfaces;
using TennoLink.Services;
using TennoLink.Services.Interfaces;

namespace TennoLink
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = RegisterDependencies();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        protected IContainer RegisterDependencies()
        {
            var config = new Config
            {
                MotdUrl = ConfigurationManager.AppSettings["MotdUrl"],
                StatusUrl = ConfigurationManager.AppSettings["WarframeApi"],
            };

            var builder = new ContainerBuilder();

            builder.RegisterType<MotdService>().As<IMotdService>();
            builder.RegisterType<WarframeStatusService>().As<IWarframeStatusService>();
            builder.RegisterType<UserLocaleService>().As<IUserLocaleService>();
            builder.RegisterType<LocalisationService>().As<ILocalisationService>().SingleInstance();

            builder.Register(p => config).As<IConfig>().SingleInstance();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

            return builder.Build();
        }
    }
}
