using System;
using System.Collections.Generic;
using System.Text;

namespace SafenedAPI.Service
{
    public interface IUserService
    {
        bool Login(string username, string password);
    }
}
