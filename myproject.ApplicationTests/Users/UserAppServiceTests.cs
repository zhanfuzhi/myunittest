using Microsoft.VisualStudio.TestTools.UnitTesting;
using myproject.ApplicationTests;
using myproject.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject.Users.Tests
{
    [TestClass()]
    public class UserAppServiceTests: myprojectBaseTest
    {
        private readonly IUserAppService _userAppService;

        public UserAppServiceTests(
            )
        {
            _userAppService= Resolve<IUserAppService>();
        }
 

        [TestMethod()]
        public void CalcTest()
        {
            _userAppService.Calc();
            Assert.Fail();
        }
    }
}