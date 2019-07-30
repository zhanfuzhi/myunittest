using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using myproject.EntityFramework;

namespace myproject
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(myprojectCoreModule))]
    public class myprojectDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<myprojectDbContext>(null);
        }
    }
}
