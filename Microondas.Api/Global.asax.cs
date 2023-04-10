using Microondas.Interface.Programacao;
using Microondas.Repository.Programacao;
using Microondas.Service.Programacao;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using Unity;
using Unity.WebApi;

namespace Microondas.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new UnityContainer();

            container.RegisterType<IProgramacaoRepository, ProgramacaoRepository>();
            container.RegisterType<IProgramacaoService, ProgramacaoService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
