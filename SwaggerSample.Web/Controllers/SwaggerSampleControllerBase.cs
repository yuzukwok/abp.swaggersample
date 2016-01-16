using Abp.Web.Mvc.Controllers;

namespace SwaggerSample.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class SwaggerSampleControllerBase : AbpController
    {
        protected SwaggerSampleControllerBase()
        {
            LocalizationSourceName = SwaggerSampleConsts.LocalizationSourceName;
        }
    }
}