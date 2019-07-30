using Abp.Modules;
using Abp.TestBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject.ApplicationTests
{
    [DependsOn(
       typeof(myprojectApplicationModule),
        typeof(myprojectCoreModule),
        typeof(myprojectDataModule),
          typeof(AbpTestBaseModule)
       )]
    public class myprojectModule : AbpModule
    {
    }
}
