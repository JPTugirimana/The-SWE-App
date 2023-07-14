using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sweapp.Models;

namespace sweapp.Data
{
    public class SweappContext : IdentityDbContext<IdentityUser>
    {
        public SweappContext (DbContextOptions<SweappContext> options)
            : base(options)
        {
        }

        public DbSet<sweapp.Models.Project> Project { get; set; } = default!;

    }
}
