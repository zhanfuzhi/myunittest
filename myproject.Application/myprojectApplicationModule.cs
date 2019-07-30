using System.Reflection;
using Abp.Modules;

namespace myproject
{
    [DependsOn(typeof(myprojectCoreModule))]
    public class myprojectApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
