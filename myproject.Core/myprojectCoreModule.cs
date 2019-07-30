using System.Reflection;
using Abp.Modules;

namespace myproject
{
    public class myprojectCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
