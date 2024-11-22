using EventureApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventureApp.business
{
    internal class UserManager
    {
        private readonly MyDbContext _dbContext;

        public UserManager(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private bool UsernameExists(string username)
        {
            return _dbContext.Users.Any(u => u.Username == username);
        }

        private User? GetByUsername(string username)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Username == username);
        }

    }
}
