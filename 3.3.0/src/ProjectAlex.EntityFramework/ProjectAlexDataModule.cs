using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ProjectAlex.EntityFramework;

namespace ProjectAlex
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ProjectAlexCoreModule))]
    public class ProjectAlexDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ProjectAlexDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
