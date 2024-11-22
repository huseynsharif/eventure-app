using EventureApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventureApp.business
{
    internal class EventManager
    {
        private readonly MyDbContext _dbContext;

        public EventManager(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
