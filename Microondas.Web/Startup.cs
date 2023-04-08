using Microsoft.Owin;

using Owin;

using System;
using System.Collections.Generic;
using System.Linq;

[assembly: OwinStartup(typeof(Microondas.Web.Startup))]

namespace Microondas.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
