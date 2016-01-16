using Abp.Application.Services;

namespace SwaggerSample
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SwaggerSampleAppServiceBase : ApplicationService
    {
        protected SwaggerSampleAppServiceBase()
        {
            LocalizationSourceName = SwaggerSampleConsts.LocalizationSourceName;
        }
    }
}