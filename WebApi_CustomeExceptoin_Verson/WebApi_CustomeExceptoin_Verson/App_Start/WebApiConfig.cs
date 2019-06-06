using Microsoft.Web.Http.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using WebApi_CustomeExceptoin_Verson.CustomHandler;

namespace WebApi_CustomeExceptoin_Verson
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.AddApiVersioning(o =>
            {
                o.ReportApiVersions = true;
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new Microsoft.Web.Http.ApiVersion(2, 0);
                o.ApiVersionReader = new HeaderApiVersionReader("version");
                o.ApiVersionSelector = new CurrentImplementationApiVersionSelector(o);
            }
            );

            config.MapHttpAttributeRoutes();
            config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
