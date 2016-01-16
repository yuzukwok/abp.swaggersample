using System.Reflection;
using Abp.Modules;

namespace SwaggerSample
{
    public class SwaggerSampleCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
