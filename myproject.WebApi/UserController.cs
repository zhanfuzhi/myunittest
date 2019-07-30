using Abp.Domain.Uow;
using Abp.Web.Models;
using Abp.Web.Security.AntiForgery;
using Abp.WebApi.Controllers;
using myproject.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    [DontWrapResult]
    [DisableAbpAntiForgeryTokenValidation]
    [UnitOfWork(false)]
    public class UserController : AbpApiController
    {
        private readonly IUserAppService _userAppService;

        public UserController(
            IUserAppService userAppService
            )
        {
            this._userAppService = userAppService;
        }

        public string Post(string id)
        {
            _userAppService.Calc();
            return id;
        }
    }
}
