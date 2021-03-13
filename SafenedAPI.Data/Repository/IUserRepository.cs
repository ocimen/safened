using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafenedAPI.Domain;

namespace SafenedAPI.Data.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        bool Login(string username, string password);
    }
}
