using Abp.Web.Mvc.Views;

namespace SwaggerSample.Web.Views
{
    public abstract class SwaggerSampleWebViewPageBase : SwaggerSampleWebViewPageBase<dynamic>
    {

    }

    public abstract class SwaggerSampleWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SwaggerSampleWebViewPageBase()
        {
            LocalizationSourceName = SwaggerSampleConsts.LocalizationSourceName;
        }
    }
}