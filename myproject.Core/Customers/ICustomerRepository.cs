using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject.Customers
{
    public interface ICustomerRepository: ITransientDependency
    {
        void First();
    }
}
