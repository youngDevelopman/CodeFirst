
using System.Data.Entity;

namespace CodeFirst
{
    class UserContext : DbContext
    {
        public UserContext() :
            base("UserDB")
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<User> UsersTest { get; set; }
    }
}
