using System.Reflection;
using Abp.Modules;

namespace SwaggerSample
{
    [DependsOn(typeof(SwaggerSampleCoreModule))]
    public class SwaggerSampleApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
