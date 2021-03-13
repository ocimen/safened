using System;
using System.Collections.Generic;
using System.Text;
using SafenedAPI.Data.Repository;

namespace SafenedAPI.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool Login(string username, string password)
        {
            return userRepository.Login(username, password);
        }
    }
}
