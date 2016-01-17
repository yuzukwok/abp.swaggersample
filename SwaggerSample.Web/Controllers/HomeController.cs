using System;
using System.Diagnostics;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace SwaggerSample.Web.Controllers
{
    public class HomeController : SwaggerSampleControllerBase
    {
        public ActionResult Index()
        {


          
            IApiExplorer apiExplorer = GlobalConfiguration.Configuration.Services.GetApiExplorer();

            foreach (ApiDescription api in apiExplorer.ApiDescriptions)
               {
                   Debug.Print("Uri path: {0}", api.RelativePath);
                Debug.Print("HTTP method: {0}", api.HttpMethod);
                  foreach (ApiParameterDescription parameter in api.ParameterDescriptions)
                     {
                         Debug.Print("Parameter: {0} - {1}", parameter.Name, parameter.Source);
                     }
                Debug.Print("");
                }

            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}