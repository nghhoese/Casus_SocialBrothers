using Microsoft.EntityFrameworkCore;
using System;

namespace Casus_SocialBrothers
{
    public class appDBcontext:DbContext
    {
        public DbSet<Address> Dept { get; set; }
        public appDBcontext(DbContextOptions<appDBcontext> options) : base(options)
        {

        }

    }
}
