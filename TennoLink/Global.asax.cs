using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TennoLink.Models;
using TennoLink.Services;

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

            RegisterDependencies();
        }

        protected IContainer RegisterDependencies()
        {
            var config = new Config
            {
                MotdUrl = ConfigurationManager.AppSettings["MotdUrl"],
                StatusUrl = ConfigurationManager.AppSettings["WarframeApi"],
            };

            var container = new ContainerBuilder();

            container.RegisterType<MotdService>().As<IMotdService>();
            container.RegisterType<WarframeStatusService>().As<IWarframeStatusService>();

            container.Register(p => config).As<IConfig>();

            return container.Build();
        }
    }
}
