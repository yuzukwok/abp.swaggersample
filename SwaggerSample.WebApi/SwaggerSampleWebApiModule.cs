using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace SwaggerSample
{
    [DependsOn(typeof(AbpWebApiModule),typeof(AbpWebApiSwaggerModule), typeof(SwaggerSampleApplicationModule))]
    public class SwaggerSampleWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(SwaggerSampleApplicationModule).Assembly, "app")
                .Build();

            Abp.Web.Api.Swagger.SwaggerBuilder.EnableSwaggerJson();
        }
    }
}
