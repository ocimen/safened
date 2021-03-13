using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafenedAPI.Domain;

namespace SafenedAPI.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SafenedContext customerContext) : base(customerContext)
        {
        }

        public bool Login(string username, string password)
        {
            return SafenedContext.User.Any(u => u.UserName == username && u.Password == password);
        }
    }
}
