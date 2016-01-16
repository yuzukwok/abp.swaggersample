using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using SwaggerSample.EntityFramework;

namespace SwaggerSample
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(SwaggerSampleCoreModule))]
    public class SwaggerSampleDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<SwaggerSampleDbContext>(null);
        }
    }
}
