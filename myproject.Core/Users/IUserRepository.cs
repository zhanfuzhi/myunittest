using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject.Users
{
    public interface IUserRepository: ITransientDependency
    {
        void First();
    }
}
