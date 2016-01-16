using System.Web.Mvc;

namespace SwaggerSample.Web.Controllers
{
    public class HomeController : SwaggerSampleControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}