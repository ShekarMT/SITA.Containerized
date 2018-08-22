using SITA_MultiProject16.Api.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Microsoft.ApplicationInsights.Extensibility;
using System.Configuration;


namespace SITA_MultiProject16.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapperConfig.Initialize();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //FilterConfig.RegisterGlobalFilters(ValidateModelFilte);
            UnityConfig.RegisterComponents();
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(new QueryStringMapping("json", "true", "application/json"));
            InitializeApplicationInsights();
        }


        private static void InitializeApplicationInsights()
        {
            TelemetryConfiguration.Active.InstrumentationKey =
            ConfigurationManager.AppSettings["ai:InstrumentationKey"];
        }

    }
}
