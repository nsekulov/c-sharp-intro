using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UserLogin
{
    internal class UserContext : DbContext
    {
        public UserContext()
            : base(Properties.Settings.Default.DbConnect)
        { }
        public DbSet<User> User { get; set; }
    }
}
