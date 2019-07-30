using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace myproject
{
    [DependsOn(typeof(AbpWebApiModule), typeof(myprojectApplicationModule))]
    public class myprojectWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(myprojectApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
