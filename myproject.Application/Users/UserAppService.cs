using myproject.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject.Users
{
    public class UserAppService:IUserAppService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICustomerRepository _customerRepository;

        public UserAppService(
            IUserRepository userRepository,
            ICustomerRepository customerRepository
            )
        {
            this._userRepository = userRepository;
            this._customerRepository = customerRepository;
        }
        public void Calc()
        {
            _userRepository.First();
            _customerRepository.First();
        }
    }
}
