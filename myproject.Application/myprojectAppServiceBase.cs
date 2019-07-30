using Abp.Application.Services;

namespace myproject
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class myprojectAppServiceBase : ApplicationService
    {
        protected myprojectAppServiceBase()
        {
            LocalizationSourceName = myprojectConsts.LocalizationSourceName;
        }
    }
}